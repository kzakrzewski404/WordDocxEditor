using System;
using System.IO;
using Microsoft.Office.Interop.Word;


namespace WordDocxEditor
{
    public class Generator
    {
        private static string _desktopPath = "";
        private static bool _isInitialized;
        private static Application wordApp;

        private string _outputFilePath = "";


        public void Generate(string sourceTemplatePath, GeneratorData data, bool doPrint = false, int numberOfCopies = 0)
        {
            Initialize();

            _outputFilePath = _desktopPath + data.Name;
            File.Copy(sourceTemplatePath, _outputFilePath);

            Document doc = wordApp.Documents.Open(_outputFilePath, ReadOnly: false);

        }


        private void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;

                _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";

                wordApp = new Application();
            }
        }
    }
}
