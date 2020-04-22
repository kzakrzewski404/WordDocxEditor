using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace WordDocxEditor.Shared.Data
{
    public class DirectoryPaths
    {
        public string DesktopOutput => Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";

        public void OpenOutputDirectoryInExplorer()
        {
            if (Directory.Exists(DesktopOutput))
            {
                Process.Start("explorer.exe", DesktopOutput);
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