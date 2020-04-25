using System.Collections.Generic;


namespace WordDocxEditor.Archiver
{
    public class ArchiverData
    {
        public string Name { get; private set; }
        public List<string> Files { get; private set; }

        public int NumberOfFiles => Files.Count;


        public ArchiverData(string templateName)
        {
            Name = templateName;
            Files = new List<string>();
        }


        public void AddFile(string fullFilePath) => Files.Add(fullFilePath);
    }
}
