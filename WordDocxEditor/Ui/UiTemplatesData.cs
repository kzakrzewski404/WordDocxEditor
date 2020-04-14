using System.Collections.Generic;


namespace WordDocxEditor.Ui
{
    public abstract class UiTemplatesData
    {
        public abstract bool IsSuccess { get; }

        public abstract Dictionary<E_TemplateId, string> FilePaths { get; }
    }
}