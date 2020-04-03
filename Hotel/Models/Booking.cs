using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int? GuestID { get; set; }
        public Guest Guest { get; set; }
        public int? RoomID { get; set; }
        public Room Room { get; set; }
    }
}