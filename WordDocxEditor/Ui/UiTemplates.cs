using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiTemplates : UiTemplatesData
    {
        private Dictionary<E_TemplateId, Label> _labels;
        private Dictionary<E_TemplateId, string> _filePaths;
        private UiCommon _common = new UiCommon();
        private const string DEFAULT_NOT_SELECTED = "<Nie wybrano>";


        public override bool IsSuccess => CheckIfLoadedSuccessfully();
        public override Dictionary<E_TemplateId, string> FilePaths => _filePaths;


        public void Bind(Dictionary<E_TemplateId, Label> labels)
        {
            _labels = labels;
        }

        public void HandleTemplatesSelectionFromDisk()
        {
            _filePaths.Clear();
            FolderBrowserDialog folderBrowser = CreateFolderBrowser();

            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowser.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles("_*");

                _filePaths.Add(E_TemplateId.Mr, FindTemplateFile(files, "_pan_"));
                _filePaths.Add(E_TemplateId.Mrs, FindTemplateFile(files, "_pani_"));
                _filePaths.Add(E_TemplateId.Company, FindTemplateFile(files, "_firma_"));
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
                    item.Value.Text = _filePaths.Where(x => x.Key == item.Key).Select(x => x.Value).First();
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