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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Event> GetData()
        {
            Event e1 = new Event() {Name = "Oasis Croke Park" , EventDate=new DateTime(2025, 06, 20), EventType = TypeOfEvent.Music };
            Event e2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), EventType = TypeOfEvent.Music };

            return new List<Event>() { e1, e2 };
        }

        private List<Ticket> GetTickets()
        {
            Ticket t1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket t2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            return new List<Ticket>() { t1, t2 };
        }

    }
}
