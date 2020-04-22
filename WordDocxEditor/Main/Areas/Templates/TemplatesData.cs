namespace WordDocxEditor.Main.Areas.Templates
{
    public abstract class TemplatesData
    {
        public abstract bool IsSuccess { get; }

        public abstract string GetFilePath(TemplateId id);
    }
}