using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketBookingApp.Models
{
    public class PassengerModel
    {
        public string passengerId { get; set; }
        public  string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
