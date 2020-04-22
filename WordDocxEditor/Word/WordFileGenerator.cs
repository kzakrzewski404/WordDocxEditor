using System;
using System.IO;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using WordApplication = Microsoft.Office.Interop.Word.Application;

using WordDocxEditor.Main.Data;
using WordDocxEditor.Shared.Config;
using WordDocxEditor.Shared.Data;


namespace WordDocxEditor.Word
{
    public class WordFileGenerator
    {
        private string _desktopOutputDirectory = "";
        private bool _isInitialized;
        private Document _document;
        private WordApplication _wordApp;


        public bool Generate(UiEntriesSummary data)
        {
            Initialize();
            string outputFilePath = GenerateOutputFilePath(data);

            if (CanCreateFile(outputFilePath))
            {
                if (TryOpenWordApp())
                {
                    File.Copy(data.SelectedTemplateFilePath, outputFilePath);

                    if (TryGenerateWordFile(outputFilePath, data))
                    {
                        HandlePrinter(data.Print.DoPrint, data.Print.NumberOfCopies);
                        CloseWordApp();
                        return true;
                    }
                }

                CloseWordApp();
            }

            return false;
        }

        private void CloseWordApp()
        {
            _document?.Close(System.Reflection.Missing.Value);
            _wordApp?.Quit();
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

        private bool TryOpenWordApp()
        {
            try
            {
                _wordApp = new WordApplication();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool TryGenerateWordFile(string targetFilePath, UiEntriesSummary data)
        {
            try
            {
                _document = _wordApp.Documents.Open(targetFilePath, ReadOnly: false);

                ReplaceTag(TagsConfig.Name, data.BasicInformations.Name);
                ReplaceTag(TagsConfig.Address, data.BasicInformations.Address);
                ReplaceTag(TagsConfig.IsStreet, data.BasicInformations.IsStreet ? "ul. " : "");
                ReplaceTag(TagsConfig.City, data.BasicInformations.City);
                ReplaceTag(TagsConfig.CaseId, data.BasicInformations.CaseId.ToString());
                ReplaceTag(TagsConfig.ReceivedDate, data.Date.Received.Date.ToString("dd.MM.yyyy"));
                ReplaceTag(TagsConfig.RespondedDate, data.Date.Response.Date.ToString("dd.MM.yyyy"));

                _document.Save();
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

        private string GenerateOutputFilePath(UiEntriesSummary data)
        {
            string targetDirectory = _desktopOutputDirectory + "\\" + new DirectoryInfo(data.SelectedTemplateFilePath).Parent.Name;

            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            targetDirectory += "\\";
            if (data.BasicInformations.DoAddCaseIdToFileName)
            {
                targetDirectory += data.BasicInformations.CaseId.ToString() + " - ";
            }

            targetDirectory += data.BasicInformations.Name + Path.GetExtension(data.SelectedTemplateFilePath);
            return targetDirectory;
        }

        private void ReplaceTag(string tag, string replacedText)
        {
            _document.Content.Find.Execute(tag, false, true, false, false, false, true, 1, false, replacedText, 2,
            false, false, false, false);
        }
    }
}