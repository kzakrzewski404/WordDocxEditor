namespace WordDocxEditor.Ui
{
    public abstract class UiInformationsData
    {
        public abstract string Name { get; }
        public abstract string Address { get; }
        public abstract bool IsStreet { get; }
        public abstract string City { get; }
        public abstract int CaseId { get; }
        public abstract E_TemplateId TemplateId { get; }
    }
}