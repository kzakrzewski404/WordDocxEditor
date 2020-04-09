using System;
using System.IO;
using Microsoft.Office.Interop.Word;


namespace WordDocxEditor
{
    public class Generator
    {
        private static string _desktopOutputDirectory = "";
        private static bool _isInitialized;
        private static Application _wordApp;
        private Document _document;

        
        public bool Generate(string templateFilePath, GeneratorData data, bool doPrint = false, int numberOfCopies = 0)
        {
            Initialize();

            string targetFilePath = PrepareTargetFilePath(templateFilePath, data);
            CopyTemplate(templateFilePath, targetFilePath);
            bool isEditSuccessful = EditWordFile(targetFilePath, data);

            if (isEditSuccessful)
            {
                HandlePrinter(doPrint, numberOfCopies);
                CloseWordFile();
                return true;
            }

            return false;
        }


        private void CloseWordFile()
        {
            object missing = System.Reflection.Missing.Value;
            _document.Close(ref missing);
        }

        private void CopyTemplate(string templateFilePath, string targetFilePath) => File.Copy(templateFilePath, targetFilePath);

        private bool EditWordFile(string targetFilePath, GeneratorData data)
        {
            bool hasTriedToLocalizeWordApp = false;
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    _document = _wordApp.Documents.Open(targetFilePath, ReadOnly: false);
                    ReplaceTag(TagsConfig.Name, data.Name);
                    ReplaceTag(TagsConfig.Address, data.Address);
                    ReplaceTag(TagsConfig.City, data.City);
                    ReplaceTag(TagsConfig.CaseId, data.CaseId.ToString());
                    ReplaceTag(TagsConfig.ReceivedDate, data.ReceivedDate.Date.ToString("dd.MM.yyyy"));
                    ReplaceTag(TagsConfig.RespondedDate, data.RespondedDate.Date.ToString("dd.MM.yyyy"));

                    _document.Save();
                    break;
                }
                catch (Exception e)
                {
                    if (hasTriedToLocalizeWordApp)
                    {
                        CloseWordFile();
                        return false;
                    }
                    else
                    {
                        hasTriedToLocalizeWordApp = true;
                        LocalizeWordApp();
                        continue;
                    }
                }
            }

            return true;
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
                _desktopOutputDirectory = PrepareDesktopOutputDirectory();
                LocalizeWordApp();
            }
        }

        private void LocalizeWordApp() => _wordApp = new Application();

        private string PrepareDesktopOutputDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";
        }

        private string PrepareTargetFilePath(string templatePath, GeneratorData data)
        {
            //Final FilePath: %Desktop%\Dokumenty - DD.MM.YYY\\template name\\Name.docx
            string targetDirectory = _desktopOutputDirectory + "\\" + new DirectoryInfo(templatePath).Parent.Name;

            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            return targetDirectory + "\\" + data.Name + Path.GetExtension(templatePath);
        }

        private void ReplaceTag(string tag, string replacedText)
        {
            _document.Content.Find.Execute(tag, false, true, false, false, false, true, 1, false, replacedText, 2,
            false, false, false, false);
        }
    }
}