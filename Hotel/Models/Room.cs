using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? TypeID { get; set; }
        public Type Type { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Utility> Utilities { get; set; }
        public Room()
        {
            Bookings = new List<Booking>();
            Utilities = new List<Utility>();
        }
    }
}