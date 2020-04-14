using System.IO;
using System.Linq;
using System.Windows.Forms;
using WordDocxEditor.Templates;

namespace WordDocxEditor
{
    public class TemplatesLoader
    {
        public TemplatesFilePaths Load()
        {
            TemplatesFilePaths summary = new TemplatesFilePaths();
            FolderBrowserDialog folderBrowserDialog = CreateFolderBrowserDialog();

            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles("_*");

                summary.AddFilePath(E_TemplateId.Mr, FindTemplateFile(files, "_pan_"));
                summary.AddFilePath(E_TemplateId.Mrs, FindTemplateFile(files, "_pani_"));
                summary.AddFilePath(E_TemplateId.Company, FindTemplateFile(files, "_firma_"));
            }
            else
            {
                MessageBox.Show("Nie wybrano folderu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return summary;
        }


        private FolderBrowserDialog CreateFolderBrowserDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Wybierz folder z trzema szablonami";

            return folderBrowserDialog;
        }

        private string FindTemplateFile(FileInfo[] files, string searchPattern)
        {
            return files.Where(x => x.Name.Contains(searchPattern)).Select(x => x.FullName).FirstOrDefault();
        }
    }
}