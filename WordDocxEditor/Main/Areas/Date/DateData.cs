using System;


namespace WordDocxEditor.Main.Areas.Date
{
    public abstract class DateData
    {
        public abstract DateTime Received { get; }
        public abstract DateTime Response { get; }
    }
}