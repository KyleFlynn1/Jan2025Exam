using System;
using System.Collections.Generic;

/*
 * Name : Kyle Flynn
 * Student Number : S00251601
 * Date : 8/1/25
 * Description : Final Exam Object Oriented Programming
 */
namespace Q1
{
    public enum TypeOfEvent { Music, Comedy, Theatre }
    public class Event : IComparable<Event>
    {
        //Properties
        #region properties

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<VIPTicket> VIPTickets { get; set; }
        public TypeOfEvent EventType { get; set; }

        #endregion properties

        //Sort by EventDate
        #region compareTo
        public int CompareTo(Event other)
        {
            return this.EventDate.Day.CompareTo(other.EventDate.Day);
        }
        #endregion compareTo

        //Constructor
        #region constructor

        public Event(string name, DateTime eventDate, TypeOfEvent eventType)
        {
            Name = name;
            EventType = eventType;
            EventDate = eventDate;
        }

        public Event() : this("Unknown", DateTime.Now, TypeOfEvent.Music ) { }

        public Event(string name,TypeOfEvent itemType)
            : this(name, DateTime.Now, itemType) { }


        public override string ToString()
        {
            return $"{Name} - {EventDate:d}";
        }
        #endregion Constructors

        #region methods
        public List<Ticket> GetTickets()
        {
            return Tickets ;
        }
        #endregion methods
    }
}
