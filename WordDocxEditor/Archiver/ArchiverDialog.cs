using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Shared.Config;
using WordDocxEditor.Shared.Data;
using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.Archiver
{
    public partial class ArchiverDialog : Form
    {
        private List<ArchiverData> _data;
        private UiMessages _messages = new UiMessages();


        public ArchiverDialog()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            richTextBox_DetectedFiles.Clear();
            richTextBox_Archived.Clear();
        }

        private void OnArchiverDialogDisplay(object sender, EventArgs e)
        {
            FindFilesToArchive();
        }

        private void FindFilesToArchive()
        {
            ClearTextBoxes();
            _data = new List<ArchiverData>();
            string generatedFilesDirectory = new OutputDirectory().DesktopPath;
            int detectedFiles = 0;

            InsertDetectedHeader("Szukam plików...");
            if (Directory.Exists(generatedFilesDirectory))
            {
                DirectoryInfo[] allTemplates = new DirectoryInfo(generatedFilesDirectory).GetDirectories();
                List<DirectoryInfo> archivableTemplates = allTemplates.Where(x => x.Name.Contains(TemplatesCfg.ArchivableTemplateName)).ToList();


                if (archivableTemplates.Count > 0)
                {
                    foreach (var template in archivableTemplates)
                    {
                        ArchiverData newTemplateData = new ArchiverData(template.Name);
                        FileInfo[] files = template.GetFiles();

                        InsertDetectedTemplateName(template.Name, files.Length);
                        if (files.Length > 0)
                        {
                            foreach (var item in files)
                            {
                                InsertDetectedFile(item.Name);
                                newTemplateData.AddFile(item.FullName);
                                detectedFiles++;
                            }
                        }
                        else
                        {
                            InsertDetectedFile("Brak plików...");
                        }

                        _data.Add(newTemplateData);
                    }
                }
            }
            else
            {
                InsertDetectedError("Nie znaleziono folderu z wygenerowanymi plikami.");
            }

            InsertDetectedHeader("Zakończono szukanie plików.");
            button_Archive.Enabled = detectedFiles > 0;
        }

        private void InsertDetectedHeader(string header) => InsertText($"# {header}\n", Color.Purple, richTextBox_DetectedFiles);
        private void InsertDetectedTemplateName(string name, int numberOfFiles) => InsertText($"{name} ({numberOfFiles})\n", Color.Black, richTextBox_DetectedFiles);
        private void InsertDetectedFile(string name) => InsertText($"   - {name}\n", Color.Black, richTextBox_DetectedFiles);
        private void InsertDetectedError(string error) => InsertText($"# {error}\n", Color.Red, richTextBox_DetectedFiles);

        private void InsertArchivedHeader(string header) => InsertText($"# {header}\n", Color.Purple, richTextBox_Archived);
        private void InsertArchivedError(string error) => InsertText($"# {error}\n", Color.Red, richTextBox_Archived);
        private void InsertArchivedTemplateName(string name) => InsertText($"{name}\n", Color.Black, richTextBox_Archived);
        private void InsertArchivedFileSuccess(string name) => InsertText($"   - {name}\n", Color.Green, richTextBox_Archived);
        private void InsertArchivedFileError(string name, string error) => InsertText($"   - {name} ({error})\n", Color.Red, richTextBox_Archived);


        private void InsertText(string msg, Color color, RichTextBox richTextBox)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;

            richTextBox.SelectionColor = color;
            richTextBox.AppendText(msg);
        }


        private void button_Archive_Click(object sender, EventArgs e)
        {
            button_Archive.Enabled = false;
            int succesFiles = 0;
            int totalFiles = 0;
            InsertArchivedHeader("Rozpoczynam archiwizację...");
            if (Directory.Exists(DirectoriesCfg.Archive))
            {
                foreach (var template in _data)
                {
                    if (template.NumberOfFiles > 0)
                    {
                        InsertArchivedTemplateName(template.Name);

                        foreach (var item in template.Files)
                        {
                            string name = Path.GetFileNameWithoutExtension(item);
                            string nameExt = Path.GetFileName(item);
                            string archiveTarget = $"{DirectoriesCfg.Archive}\\{name}";
                            totalFiles++;

                            if (Directory.Exists(archiveTarget))
                            {
                                string targetFilePath = $"{archiveTarget}\\{nameExt}";
                                if (File.Exists(targetFilePath))
                                {
                                    InsertArchivedFileError(name, "plik już istnieje");
                                }
                                else
                                {
                                    InsertArchivedFileSuccess(name);
                                    succesFiles++;
                                    File.Copy(item, $"{archiveTarget}\\{nameExt}");

                                    string localArchivedDir = $"{Path.GetDirectoryName(item)}\\Zarchiwizowane";
                                    Directory.CreateDirectory(localArchivedDir);
                                    File.Move(item, $"{localArchivedDir}\\{nameExt}");
                                }
                            }
                            else
                            {
                                InsertArchivedFileError(name, "nie odnaleziono folderu");
                            }
                        }
                    }
                }
            }
            else
            {
                InsertArchivedError($"Nie można wykonać archiwizacji, {DirectoriesCfg.Archive} jest nieosiągalny.");
            }

            InsertArchivedHeader($"Zakończono archiwizację, przeniesiono {succesFiles} z {totalFiles} plików.");
        }

        private void button_OpenArchiveDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DirectoriesCfg.Archive))
            {
                Process.Start(DirectoriesCfg.Archive);
            }
            else
            {
                _messages.ShowError($"Nie można odnaleźć ścieżki {DirectoriesCfg.Archive}");
            }
            
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            FindFilesToArchive();
        }
    }
}
