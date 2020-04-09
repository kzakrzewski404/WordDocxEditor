namespace WordDocxEditor
{
    public class TemplatesLoaderSummary
    {
        public string[] FilePaths { get; private set; }

        public bool IsSuccess => CheckIfLoadedSuccessfully();


        public TemplatesLoaderSummary() => FilePaths = new string[(int)E_TemplateId.ENUM_LENGTH];


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