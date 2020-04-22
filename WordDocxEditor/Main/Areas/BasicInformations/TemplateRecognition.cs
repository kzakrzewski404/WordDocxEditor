using System;
using System.Linq;

using WordDocxEditor.Main.Areas.Templates;


namespace WordDocxEditor.Main.Areas.BasicInformations
{
    public class TemplateRecognition
    {
        public TemplateId RecognizeByName(string name)
        {
            if (name.Contains("."))
            {
                return TemplateId.Company;
            }
            else if (!String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name))
            {
                var separated = name.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? TemplateId.Mrs : TemplateId.Mr;
            }

            return TemplateId.Mr;
        }
    }
}