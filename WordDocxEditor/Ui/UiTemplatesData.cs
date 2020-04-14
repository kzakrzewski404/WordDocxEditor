using WordDocxEditor.Generator;


namespace WordDocxEditor.Ui
{
    public abstract class UiTemplatesData
    {
        public abstract bool IsSuccess { get; }

        public abstract string GetFilePath(TemplateId id);
    }
}