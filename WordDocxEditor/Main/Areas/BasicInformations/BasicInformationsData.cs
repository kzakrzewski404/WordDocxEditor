using WordDocxEditor.Main.Areas.Templates;


namespace WordDocxEditor.Main.Areas.BasicInformations
{
    public abstract class BasicInformationsData
    {
        public abstract string Name { get; }
        public abstract string Address { get; }
        public abstract bool IsStreet { get; }
        public abstract string City { get; }
        public abstract int CaseId { get; }
        public abstract TemplateId SelectedTemplate { get; }
        public abstract bool DoAddCaseIdToFileName { get; }
    }
}