using System;


namespace WordDocxEditor
{
    public class GeneratorData
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public bool IsStreet { get; private set; }
        public string City { get; private set; }
        public int CaseId { get; private set; }
        public DateTime ReceivedDate { get; private set; }
        public DateTime RespondedDate { get; private set; }


        public GeneratorData(string name, string address, bool isStreet, string city, int caseId, DateTime received, DateTime responded)
        {
            Name = name;
            Address = address;
            IsStreet = isStreet;
            City = city;
            CaseId = caseId;
            ReceivedDate = received;
            RespondedDate = responded;
        }
    }
}
