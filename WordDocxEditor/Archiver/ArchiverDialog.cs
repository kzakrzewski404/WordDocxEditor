using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        private const string SPACER = "    - ";
        private List<ArchiverData> _data = new List<ArchiverData>();
        private UiMessages _messages = new UiMessages();
        private int failedToArchiveFiles;
        private int archivedFiles;


        public ArchiverDialog()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            richTextBox_DetectedFiles.Clear();
            richTextBox_Archived.Clear();
            richTextBox_FailedToArchive.Clear();
        }

        private void ArchiverDialog_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            string generatedFilesDirectory = new DirectoryPaths().DesktopOutput;
            int detectedFiles = 0;

            if (Directory.Exists(generatedFilesDirectory))
            {
                DirectoryInfo[] allTemplates = new DirectoryInfo(generatedFilesDirectory).GetDirectories();
                List<DirectoryInfo> archivableTemplates = allTemplates.Where(x => x.Name.Contains(TemplatesCfg.ArchivableTemplateName)).ToList();

                InsertDetectedFileTitle("Rozpoczynam sprawdzanie plików...\n\n");
                if (archivableTemplates.Count > 0)
                {
                    foreach (var template in archivableTemplates)
                    {
                        ArchiverData newTemplateData = new ArchiverData(template.Name);
                        FileInfo[] files = template.GetFiles();

                        InsertDetectedFileTitle($"Sprawdzam szablon \"{template.Name}\" ({files.Length})...\n");
                        if (files.Length > 0)
                        {
                            foreach (var item in files)
                            {
                                InsertDetectedText($"{item.Name}\n");
                                newTemplateData.AddFile(item.FullName);
                                detectedFiles++;
                            }

                            richTextBox_DetectedFiles.Text += "\n";
                        }
                        else
                        {
                            InsertDetectedText($"Brak plików...\n\n");
                        }

                        _data.Add(newTemplateData);
                    }
                    InsertDetectedFileTitle("Zakończono.");
                }
                else
                {
                    InsertDetectedFileTitle("Nic nie znaleziono.");
                }
            }
            else
            {
                InsertDetectedFileTitle("Nie znaleziono folderu z wygenerowanymi plikami.");
            }

            label_FilesToArchive.Text = detectedFiles.ToString();
            if (detectedFiles == 0)
            {
                button_Archive.Enabled = false;
            }
        }

        private void InsertDetectedText(string msg) => InsertTextBoxMsg($"{SPACER}{msg}", richTextBox_DetectedFiles);
        private void InsertDetectedFileTitle(string msg) => InsertTextBoxMsg($"# {msg}", richTextBox_DetectedFiles);

        private void InsertTextBoxMsg(string msg, RichTextBox target) => target.Text += msg;

        private void InsertArchivedFileText(string fileName, bool isSuccess)
        {
            if (isSuccess)
            {
                archivedFiles++;
                richTextBox_Archived.Text += $"{SPACER}{fileName}";
            }
            else
            {
                failedToArchiveFiles++;
                richTextBox_FailedToArchive.Text += $"{SPACER}{fileName}";
            }
        }

        private void InsertArchivingTemplate(string msg)
        {
            richTextBox_Archived.Text += msg;
            richTextBox_FailedToArchive.Text += msg;
        }

        private void button_Archive_Click(object sender, EventArgs e)
        {
            button_Archive.Enabled = false;
            if (Directory.Exists(DirectoriesCfg.Archive))
            {
                foreach (var template in _data)
                {
                    if (template.NumberOfFiles > 0)
                    {
                        InsertArchivingTemplate($"{template.Name}:\n");

                        foreach (var item in template.Files)
                        {
                            string name = Path.GetFileNameWithoutExtension(item);
                            string nameExt = Path.GetFileName(item);
                            string archiveTarget = $"{DirectoriesCfg.Archive}\\{name}";

                            if (Directory.Exists(archiveTarget))
                            {
                                string targetFilePath = $"{archiveTarget}\\{nameExt}";
                                if (File.Exists(targetFilePath))
                                {
                                    InsertArchivedFileText($"{name} (już istnieje)\n", false);
                                }
                                else
                                {
                                    InsertArchivedFileText($"{name}\n", true);
                                    File.Copy(item, $"{archiveTarget}\\{nameExt}");

                                    string localArchivedDir = $"{Path.GetDirectoryName(item)}\\Zarchiwizowane";
                                    Directory.CreateDirectory(localArchivedDir);
                                    File.Move(item, $"{localArchivedDir}\\{nameExt}");
                                }
                            }
                            else
                            {
                                InsertArchivedFileText($"{name} (nie znaleziono)\n", false);
                            }
                        }

                        InsertArchivingTemplate("\n");
                    }
                }

                InsertArchivingTemplate("# Zakończono\n");
            }
            else
            {
                _messages.ShowError("Nie można wykonać archiwizacji, folder docelowy jest nieosiągalny.");
            }

            label_FilesArchived.Text = archivedFiles.ToString();
            label_FilesFailedToArchive.Text = failedToArchiveFiles.ToString();
        }

        private void button_OpenArchiveDir_Click(object sender, EventArgs e)
        {
            Process.Start(DirectoriesCfg.Archive);
        }
    }
}
