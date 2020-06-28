using System;

namespace CalendarExtended.Shared
{
    public class CalendarEvent
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
