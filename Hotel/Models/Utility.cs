using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Utility
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public ICollection<Room> Rooms { get; set; }
        public Utility()
        {
            Rooms = new List<Room>();
        }
    }
}