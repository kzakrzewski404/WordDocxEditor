using System;


namespace WordDocxEditor
{
    public class GeneratorData
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public int CaseId { get; private set; }
        public DateTime ReceivedDate { get; private set; }
        public DateTime RespondedDate { get; private set; }
        public string TemplateName { get; private set; }

        public GeneratorData(string name, string address, string city, int caseId, DateTime received, DateTime responded, 
                             string templateName)
        {
            Name = name;
            Address = address;
            City = city;
            CaseId = caseId;
            ReceivedDate = received;
            RespondedDate = responded;
            TemplateName = templateName;
        }
    }
}
