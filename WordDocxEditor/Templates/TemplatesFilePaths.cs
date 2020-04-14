using System.Collections.Generic;


namespace WordDocxEditor.Templates
{
    public class TemplatesFilePaths
    {
        private 

        public bool IsSuccess => CheckIfLoadedSuccessfully();


        public TemplatesFilePaths() => FilePaths = new string[(int)E_TemplateId.ENUM_LENGTH];


        public void AddFilePath(E_TemplateId id, string path) => FilePaths[(int)id] = path;


        private bool CheckIfLoadedSuccessfully()
        {
            foreach (var item in FilePaths)
            {
                if (item == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}