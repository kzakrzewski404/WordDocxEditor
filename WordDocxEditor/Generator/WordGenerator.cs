using System;
using System.IO;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;

using WordDocxEditor.Config;
using WordDocxEditor.Ui;
using WordDocxEditor.Common;


namespace WordDocxEditor.Generator
{
    public class WordGenerator
    {
        private static string _desktopOutputDirectory = "";
        private static bool _isInitialized;
        private Document _document;


        public bool Generate(UiInputSummary data)
        {
            Initialize();

            string outputFilePath = GenerateOutputFilePath(data);

            if (CanCreateFile(outputFilePath))
            {
                File.Copy(data.SelectedTemplateFilePath, outputFilePath);

                if (TryGenerateWordFile(outputFilePath, data))
                {
                    HandlePrinter(data.Print.DoPrint, data.Print.NumberOfCopies);
                    return true;
                }
            }

            return false;
        }


        private bool CanCreateFile(string targetFilePath)
        {
            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show($"Plik {Path.GetFileName(targetFilePath)} już istnieje, nadpisać?", 
                                                      "Plik już istnieje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    File.Delete(targetFilePath);
                    return true;
                }

                return false;
            }

            return true;
        }

        private bool TryGenerateWordFile(string targetFilePath, UiInputSummary data)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                _document = wordApp.Documents.Open(targetFilePath, ReadOnly: false);
                ReplaceTag(TagsConfig.Name, data.Informations.Name);
                ReplaceTag(TagsConfig.Address, data.Informations.Address);
                ReplaceTag(TagsConfig.IsStreet, data.Informations.IsStreet ? "ul. " : "");
                ReplaceTag(TagsConfig.City, data.Informations.City);
                ReplaceTag(TagsConfig.CaseId, data.Informations.CaseId.ToString());
                ReplaceTag(TagsConfig.ReceivedDate, data.Date.Received.Date.ToString("dd.MM.yyyy"));
                ReplaceTag(TagsConfig.RespondedDate, data.Date.Response.Date.ToString("dd.MM.yyyy"));

                _document.Save();
                _document.Close(System.Reflection.Missing.Value);
                wordApp.Quit();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void HandlePrinter(bool doPrint, int numberOfCopies)
        {
            if (doPrint)
            {
                _document.PrintOut(Copies: numberOfCopies);
            }
        }

        private void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
                _desktopOutputDirectory = new DirectoryPaths().DesktopOutput;
            }
        }

        private string GenerateOutputFilePath(UiInputSummary data)
        {
            //Final FilePath: %Desktop%\Dokumenty - DD.MM.YYY\\template name\\Name.docx
            string targetDirectory = _desktopOutputDirectory + "\\" + new DirectoryInfo(data.SelectedTemplateFilePath).Parent.Name;

            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            targetDirectory += "\\";
            if (data.Informations.DoAddCaseIdToFileName)
            {
                targetDirectory += data.Informations.CaseId.ToString() + " - ";
            }

            targetDirectory += data.Informations.Name + Path.GetExtension(data.SelectedTemplateFilePath);
            return targetDirectory;
        }

        private void ReplaceTag(string tag, string replacedText)
        {
            _document.Content.Find.Execute(tag, false, true, false, false, false, true, 1, false, replacedText, 2,
            false, false, false, false);
        }
    }
}