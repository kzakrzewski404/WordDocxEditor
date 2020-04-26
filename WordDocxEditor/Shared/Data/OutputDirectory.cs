using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace WordDocxEditor.Shared.Data
{
    public class OutputDirectory
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";

        public void OpenOutputDirectoryInExplorer()
        {
            if (Directory.Exists(DesktopPath))
            {
                Process.Start("explorer.exe", DesktopPath);
            }
            else
            {
                MessageBox.Show("Folder wyjściowy nie został jeszcze utworzony.\n" +
                                "Wygeneruj najpierw dowolny dokument.",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}