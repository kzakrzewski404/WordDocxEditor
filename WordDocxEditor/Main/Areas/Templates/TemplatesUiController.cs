using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.Main.Areas.Templates
{
    public class TemplatesUiController : TemplatesData
    {
        private Dictionary<TemplateId, Label> _labels;
        private Dictionary<TemplateId, string> _filePaths = new Dictionary<TemplateId, string>();
        private UiMessages _common = new UiMessages();
        private const string DEFAULT_NOT_SELECTED = "<Nie wybrano>";


        public override bool IsSuccess => CheckIfLoadedSuccessfully();


        public void Bind(Dictionary<TemplateId, Label> labels)
        {
            _labels = labels;
        }

        public override string GetFilePath(TemplateId id) => _filePaths.Where(x => x.Key == id).Select(x => x.Value).FirstOrDefault();

        public void HandleTemplatesSelectionFromDisk()
        {
            _filePaths.Clear();
            FolderBrowserDialog folderBrowser = CreateFolderBrowser();

            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowser.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles("_*");

                if (files.Length > (int)TemplateId.ENUM_LENGTH)
                {
                    _common.ShowError($"W wybranym folderze znajduje się więcej niż {(int)TemplateId.ENUM_LENGTH} wymagane pliki.");
                }
                else
                {
                    _filePaths.Add(TemplateId.Mr, FindTemplateFile(files, "_pan_"));
                    _filePaths.Add(TemplateId.Mrs, FindTemplateFile(files, "_pani_"));
                    _filePaths.Add(TemplateId.Company, FindTemplateFile(files, "_firma_"));

                    if (_filePaths.Any(x => string.IsNullOrEmpty(x.Value)))
                    {
                        _common.ShowError($"Nie odnaleziono {(int)TemplateId.ENUM_LENGTH} plików z szablonami zaczynających się od:\n_pan_*\n_pani_*\n_firma_*");
                    }
                }
            }
            else
            {
                _common.ShowError("Nie wybrano folderu.");
            }

            RefreshUiLabels();
        }

        private string FindTemplateFile(FileInfo[] files, string searchPattern)
        {
            return files.Where(x => x.Name.Contains(searchPattern)).Select(x => x.FullName).FirstOrDefault();
        }

        private void RefreshUiLabels()
        {
            if (IsSuccess)
            {
                foreach (var item in _labels)
                {
                    item.Value.Text = Path.GetFileName(_filePaths.Where(x => x.Key == item.Key).Select(x => x.Value).First());
                }
            }
            else
            {
                foreach (var item in _labels)
                {
                    item.Value.Text = DEFAULT_NOT_SELECTED;
                }
            }
        }

        private FolderBrowserDialog CreateFolderBrowser()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Wybierz folder z trzema szablonami";

            return folderBrowser;
        }

        private bool CheckIfLoadedSuccessfully()
        {
            if (_filePaths.Count != 3)
            {
                return false;
            }

            foreach (var item in _filePaths)
            {
                if (item.Value == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}