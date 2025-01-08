using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

/*
 * Name : Kyle Flynn
 * Student Number : S00251601
 * Date : 8/1/25
 * Description : Final Exam Object Oriented Programming
 */

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private List<Event> events;
        private List<Event> filteredEventItems;
        private Event selectedEvent;
        private Ticket selectedTicket;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            events = GetData();
            UpdateDisplay(events);
        }

        private List<Event> GetData()
        {
            Event e1 = new Event() {Name = "Oasis Croke Park" , EventDate=new DateTime(2025, 06, 20), EventType = TypeOfEvent.Music };
            Event e2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), EventType = TypeOfEvent.Music };

            e1.Tickets = GetTickets();
            e1.VIPTickets = GetVIPTickets();

            e2.Tickets = GetTickets();
            e2.VIPTickets = GetVIPTickets();

            return new List<Event>() { e1, e2 };
        }

        private List<Ticket> GetTickets()
        {
            Ticket t1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket t2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            return new List<Ticket>() { t1, t2};
        }

        private List<VIPTicket> GetVIPTickets()
        {
            VIPTicket t1 = new VIPTicket() { name = "Ticket and Hotel Package", price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel", availableTickets = 100 };
            VIPTicket t2 = new VIPTicket() { name = "Weekend Ticket", price = 200m, AdditionalCost = 100m, AdditionalExtras = "with Camping", availableTickets = 100 };

            return new List<VIPTicket>() { t1,t2 };
        }

        //Method to reset and refresh the display
        private void UpdateDisplay(List<Event> items)
        {
            //reset the listboxes
            EventListBox.ItemsSource = null;
            TicketsListBox.ItemsSource = null;

            //Sort Events making use of IComparable
            items.Sort();

            //Update
            EventListBox.ItemsSource = events;
            if (EventListBox.SelectedItem != null)
            {
                selectedEvent = EventListBox.SelectedItem as Event;
                TicketsListBox.ItemsSource = selectedEvent.Tickets;
                TicketsListBox.ItemsSource = selectedEvent.VIPTickets;
            }
        }

        //Filter but name of items passed - used for search
        private List<Event> FilterEventByName(List<Event> events, string searchTerm)
        {
            List<Event> filteredList = new List<Event>();

            foreach (Event item in events)
            {
                if (item.Name.ToLower().Contains(searchTerm.ToLower()))
                    filteredList.Add(item);
            }

            return filteredList;
        }

        private void SearchTBX_KeyUp(object sender, KeyEventArgs e)
        {
            //Check the text in the searchbox
            string searchTerm = SearchTBX.Text;

            if (string.IsNullOrEmpty(searchTerm))

                //if empty display all
                UpdateDisplay(events);

            else
            {
                //if not empty search items for matches
                filteredEventItems = FilterEventByName(events, searchTerm);  //method call to return filtered results


                //display matches on screen
                UpdateDisplay(filteredEventItems);

            }

        }

        private void PurchaseTicket(Ticket ticket)
        {
            int selectedAmount;
            selectedAmount = int.Parse(TicketAmountTBX.Text);
            if (ticket.AvailableTickets <= selectedAmount) 
            {
                ticket.AvailableTickets = ticket.AvailableTickets - selectedAmount;
            }
        }

        private void BookBTN_Click(object sender, RoutedEventArgs e)
        {
            PurchaseTicket(selectedTicket);
        }

        private void EventListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EventListBox.SelectedItem != null)
            {
                selectedEvent = EventListBox.SelectedItem as Event;
                TicketsListBox.ItemsSource = selectedEvent.Tickets;
            }
        }

        private void TicketsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TicketsListBox.SelectedItem != null)
            {
                selectedTicket = TicketsListBox.SelectedItem as Ticket;
            }
        }
    }
}
