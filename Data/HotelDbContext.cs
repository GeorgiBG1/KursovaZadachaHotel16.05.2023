using KursovaHotel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext()
        {
            //this.Database.EnsureCreated();
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<MenuVariety> MenuVarieties { get; set; }
        public DbSet<MenuOption> MenuOptions { get; set; }
        public DbSet<MenuDate> MenuDates { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=HotelDB;" +
                    "Integrated Security=true;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
