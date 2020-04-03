using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxPer { get; set; }
        public ICollection<Room> Rooms{ get; set; }
        public Type()
        {
           Rooms = new List<Room>();
        }
    }
}