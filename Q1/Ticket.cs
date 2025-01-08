using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Name : Kyle Flynn
 * Student Number : S00251601
 * Date : 8/1/25
 * Description : Final Exam Object Oriented Programming
 */
namespace Q1
{
    public class Ticket
    {
        //Properties
        #region properties

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        #endregion properties

        //Constructor
        #region constructors
        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }

        public Ticket() : this("Unknown", 0.00m , 0) { }

        public Ticket(string name)
            : this(name, 0.00m, 0) { }

        public override string ToString()
        {
            return $"{Name} - {Price} [AVAILABLE - {AvailableTickets}])";
        }
        #endregion constructors
    }

    public class VIPTicket
    {
        //Properties
        #region properties

        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
        internal string name;
        internal int availableTickets;
        internal decimal price;

        #endregion properties

        //Constructor
        #region constructors
        public VIPTicket(string name, decimal price, decimal additionalCost ,string additionalExtras, int availableTickets)
        {
            Ticket ticket = new Ticket(name, price, availableTickets);
            AdditionalCost = AdditionalCost;
            AdditionalExtras = additionalExtras;
        }

        public VIPTicket() : this("Unknown", 0.00m,0.00m,"None", 0) { }

        public override string ToString()
        {
            return $"{name} - {price + AdditionalCost} ({AdditionalExtras} [AVAILABLE - {availableTickets}])";
        }
        #endregion constructors
    }
}
