namespace WordDocxEditor.Ui
{
    public class UiInputSummary
    {
        public UiInformationsData Informations { get; private set; }
        public UiDateData Date { get; private set; }
        public UiPrintData Print { get; private set; }
        public UiTemplatesData Templates { get; private set; }


        public UiInputSummary(UiInformationsData informations, UiDateData date, UiPrintData print, UiTemplatesData templates)
        {
            Informations = informations;
            Date = date;
            Print = print;
            Templates = templates;
        }
    }
}