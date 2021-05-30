using System;

namespace Minx.Razor.Models
{
    public class CalendarItem
    {
        public Guid Reference { get; set; }

        public DateTime Date { get; set; }

        public int Channel { get; set; }

        public string Color { get; set; }

        public string Label { get; set; }

        public bool ShowLabel { get; set; }

        public bool IsTag { get; set; }

        public string TagIcon { get; set; } = "far fa-calendar";
    }
}