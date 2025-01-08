using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public enum TypeOfEvent { Music, Comedy, Theatre }
    public class Event : IComparable<Event>
    {
        //Properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public TypeOfEvent EventType { get; set; }

        //Sort by EventDate
        public int CompareTo(Event other)
        {
            return this.EventDate.Day.CompareTo(other.EventDate.Day);
        }

        //Constructor
        public Event(string name, DateTime eventDate, TypeOfEvent eventType)
        {
            Name = name;
            EventType = eventType;
            EventDate = eventDate;
        }

        public Event() : this("Unknown", DateTime.Now, TypeOfEvent.Music ) { }

        public Event(string name,TypeOfEvent itemType)
            : this(name, DateTime.Now, itemType) { }

    }
}
