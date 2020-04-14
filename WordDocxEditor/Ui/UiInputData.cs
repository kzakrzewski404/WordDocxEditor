using System;

namespace WordDocxEditor.Ui
{
    public class UiInputData
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public bool IsStreet { get; private set; }
        public string City { get; private set; }
        public int CaseId { get; private set; }
        public DateTime ReceivedDate { get; private set; }
        public DateTime ResponseDate { get; private set; }
        public E_TemplateId TemplateId { get; private set; }
        public bool DoPrint { get; private set; }
        public int NumberOfCopies { get; private set; }


        public UiInputData(string name, string address, bool isStreet, string city, int caseId, 
                           DateTime received, DateTime response, E_TemplateId templateId,
                           bool doPrint, int numberOfCopies)
        {
            Name = name;
            Address = address;
            IsStreet = isStreet;
            City = city;
            CaseId = caseId;
            ReceivedDate = received;
            ResponseDate = response;
            TemplateId = templateId;
            DoPrint = doPrint;
            NumberOfCopies = numberOfCopies;
        }
    }
}