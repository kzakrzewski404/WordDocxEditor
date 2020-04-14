using System.Collections.Generic;
using WordDocxEditor.Generator;

namespace WordDocxEditor.Ui
{
    public abstract class UiTemplatesData
    {
        public abstract bool IsSuccess { get; }

        public abstract Dictionary<TemplateId, string> FilePaths { get; }
    }
}