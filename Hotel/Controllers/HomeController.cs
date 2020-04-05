using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        HotelContext db = new HotelContext();
        public ActionResult Index()
        {
            ViewBag.Types = new SelectList(db.Types, "ID", "Name");
            return View();
        }
        public ActionResult Search (DateTime from, DateTime to, int? type)
        {

            var enRooms = new List<Room>();
            var rooms = db.Rooms.ToList();
            foreach (var i in rooms)
            {
                var book = db.Bookings.Where(f => f.RoomID == i.ID).ToList();
                var c = 0;
                foreach (var item in book)
                {
                    if (!(item.ArrivalDate >= to || item.DepartureDate <= from))
                    {
                        c++;
                    }
                }
                if (c==0)
                {
                    enRooms.Add(i);
                }
            }
            foreach (var i in enRooms)
            {
                i.Type = db.Types.Where(f => f.ID == i.TypeID).First();
            }
            var types = enRooms.Select(f => f.Type).Distinct().ToList();
            SearchModel sm = new SearchModel { types = types };
            return PartialView(sm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}