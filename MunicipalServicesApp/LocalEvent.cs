using System;

namespace MunicipalServicesApp
{
    public class LocalEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }

        public LocalEvent(string title, string description, string category, DateTime eventDate)
        {
            Title = title;
            Description = description;
            Category = category;
            EventDate = eventDate;
        }
    }
}
