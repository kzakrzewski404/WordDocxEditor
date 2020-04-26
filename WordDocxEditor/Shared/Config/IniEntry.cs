namespace WordDocxEditor.Shared.Config
{
    public class IniEntry
    {
        public IniEntry_Id Id { get; private set; }
        public string Entry { get; private set; }
        public string Value { get; private set; }


        public IniEntry(IniEntry_Id id, string entry, string value)
        {
            Id = id;
            Entry = entry;
            Value = value;
        }

        public void ChangeValue(string value) => Value = value;
    }
}