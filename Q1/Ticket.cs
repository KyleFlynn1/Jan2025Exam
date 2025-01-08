using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q1
{
    public class Ticket
    {
        //Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        //Constructor
        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }

        public Ticket() : this("Unknown", 0.00m , 0) { }

        public Ticket(string name)
            : this(name, 0.00m, 0) { }

    }

    public class VIPTicket
    {
        //Properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }

        Ticket ticket = new Ticket();
        //Constructor
        public VIPTicket(string name, decimal price, decimal additionalCost ,string additionalExtras, int availableTickets)
        {
            ticket.Name = name;
            ticket.Price = price;
            ticket.AvailableTickets = availableTickets;
            AdditionalCost = AdditionalCost;
            AdditionalExtras = additionalExtras;
        }

        public VIPTicket() : this("Unknown", 0.00m,0.00m,"None", 0) { }

        public VIPTicket(string name)
            : this(name, 0.00m, 0.00m, "None", 0) { }

    }
}
