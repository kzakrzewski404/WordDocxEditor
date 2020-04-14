using System.Linq;


namespace WordDocxEditor.Ui
{
    public class UiTemplateRecognition
    {
        public E_TemplateId RecognizeByName(string fullName)
        {
            if (fullName.Contains("."))
            {
                return E_TemplateId.Company;
            }
            else
            {
                var separated = fullName.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? E_TemplateId.Mrs : E_TemplateId.Mr;
            }
        }
    }
}