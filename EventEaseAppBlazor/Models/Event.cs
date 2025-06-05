using System;

namespace EventEaseAppBlazor.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;

        public Event() { }

        public Event(int id, string name, DateTime date, string location)
        {
            Id = id;
            Name = name;
            Date = date;
            Location = location;
        }
    }
}