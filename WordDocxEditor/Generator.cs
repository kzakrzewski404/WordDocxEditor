using System;
using System.IO;
using Microsoft.Office.Interop.Word;


namespace WordDocxEditor
{
    public class Generator
    {
        private static string _desktopPath = "";
        private static bool _isInitialized;
        private static Application _wordApp;

        private string _outputFilePath = "";
        private Document _document;


        public bool Generate(string sourceTemplatePath, GeneratorData data, bool doPrint = false, int numberOfCopies = 0)
        {
            Initialize();

            PrepareOutputDirectory();
            CopyTemplate();
            
            bool isEditSuccessful = EditWordFile();

            if (!isEditSuccessful)
            {
                HandlePrinter();
                CloseWordFile();
                return true;
            }
            else
            {
                return false;
            }

            if (!Directory.Exists(_desktopPath))
            {
                Directory.CreateDirectory(_desktopPath);
            }

            _outputFilePath = _desktopPath + "\\" + data.Name + Path.GetExtension(sourceTemplatePath);
            File.Copy(sourceTemplatePath, _outputFilePath);

            bool hasTriedToLocalizeWordApp = false;
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    _document = _wordApp.Documents.Open(_outputFilePath, ReadOnly: false);
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
                        return false;
                    }
                    else
                    {
                        hasTriedToLocalizeWordApp = true;
                        LocateWordApp();
                    }
                }
            }

            if (doPrint)
            {
                _document.PrintOut(Copies: numberOfCopies);
            }

            object missing = System.Reflection.Missing.Value;
            _document.Close(ref missing);

            return true;
        }


        private void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;

                _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";

                LocateWordApp();
            }
        }

        private void LocateWordApp() => _wordApp = new Application();

        private void ReplaceTag(string tag, string replacedText)
        {
            _document.Content.Find.Execute(tag, false, true, false, false, false, true, 1, false, replacedText, 2,
            false, false, false, false);
        }
    }
}
