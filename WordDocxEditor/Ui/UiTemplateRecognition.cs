using System;
using System.Linq;


namespace WordDocxEditor.Ui
{
    public class UiTemplateRecognition
    {
        public E_TemplateId RecognizeByName(string name)
        {
            if (name.Contains("."))
            {
                return E_TemplateId.Company;
            }
            else if (!String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name))
            {
                var separated = name.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? E_TemplateId.Mrs : E_TemplateId.Mr;
            }

            return E_TemplateId.Mr;
        }
    }
}