using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Utility> Utilities { get; set; }
        public HotelContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utility>().HasMany(c => c.Rooms)
                .WithMany(s => s.Utilities)
                .Map(t => t.MapLeftKey("UtilityID")
                .MapRightKey("RoomID")
                .ToTable("UtilityRoom"));
        }
    }
}