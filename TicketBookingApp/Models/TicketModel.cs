using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketBookingApp.Models
{
    public class TicketModel
    {
        public string Bookingid { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string BookingStatus { get; set; }
    }
}
