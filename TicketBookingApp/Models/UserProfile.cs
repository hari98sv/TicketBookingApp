using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketBookingApp.Models
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
    }
}
