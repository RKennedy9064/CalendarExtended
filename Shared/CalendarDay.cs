using System;
using System.Collections.Generic;

namespace CalendarExtended.Shared
{
    public class CalendarDay
    {
        public long Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public bool IsEmpty { get; set; }

        public List<CalendarEvent> Events { get; set; }
    }
}
