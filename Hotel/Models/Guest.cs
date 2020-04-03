using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Guest
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronimyc { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Booking>Bookings { get; set; }
        public Guest()
        {
            Bookings = new List<Booking>();
        }
    }
}