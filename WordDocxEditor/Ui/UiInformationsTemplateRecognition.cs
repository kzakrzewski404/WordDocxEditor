using System;
using System.Linq;
using WordDocxEditor.Generator;

namespace WordDocxEditor.Ui
{
    public class UiInformationsTemplateRecognition
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