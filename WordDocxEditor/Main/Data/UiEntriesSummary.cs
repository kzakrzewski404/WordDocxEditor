using WordDocxEditor.Main.Areas.BasicInformations;
using WordDocxEditor.Main.Areas.Date;
using WordDocxEditor.Main.Areas.Print;
using WordDocxEditor.Main.Areas.Templates;


namespace WordDocxEditor.Main.Data
{
    public class UiEntriesSummary
    {
        public BasicInformationsData BasicInformations { get; private set; }
        public DateData Date { get; private set; }
        public PrintData Print { get; private set; }
        public TemplatesData Templates { get; private set; }


        public string SelectedTemplateFilePath => Templates.GetFilePath(BasicInformations.SelectedTemplate);


        public UiEntriesSummary(BasicInformationsData informations, DateData date, PrintData print, TemplatesData templates)
        {
            BasicInformations = informations;
            Date = date;
            Print = print;
            Templates = templates;
        }
    }
}