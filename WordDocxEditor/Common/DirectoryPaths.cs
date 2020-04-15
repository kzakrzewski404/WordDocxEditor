using System;


namespace WordDocxEditor.Common
{
    public class DirectoryPaths
    {
        public string DesktopOutput => Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                       + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";
    }
}