using KursovaHotel.Data;
using KursovaHotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Business
{
    public class HotelBusiness
    {
        private HotelDbContext dbContext = new HotelDbContext();

        public HotelBusiness()
        {
            AddMenuTypes();
            AddRooms();
            AddMenuVarieties();
        }

        public void AddMenuTypes()
        {
            if (!dbContext.RoomTypes.Any())
            {
                RoomType roomType = new RoomType();
                roomType.Description = "Стая за двама души";
                dbContext.RoomTypes.Add(roomType);

                RoomType roomType2 = new RoomType();
                roomType2.Description = "Стая за трима души";
                dbContext.RoomTypes.Add(roomType2);

                RoomType roomType3 = new RoomType();
                roomType3.Description = "Стая за четирима души";
                dbContext.RoomTypes.Add(roomType3);

                RoomType roomType4 = new RoomType();
                roomType4.Description = "Стая за шест души";
                dbContext.RoomTypes.Add(roomType4);

                RoomType roomType5 = new RoomType();
                roomType5.Description = "Стая за десет души";
                dbContext.RoomTypes.Add(roomType5);
                dbContext.SaveChanges();
            }
        }
        public void AddRooms()
        {
            if (!dbContext.Rooms.Any())
            {
                #region Floor 1
                Room room = new Room();
                room.RoomNumber = 10;
                room.Description = "Стая с две двойни легла, с вана и мини бар.";
                room.Price = 150;
                room.RoomTypeId = 3;
                dbContext.Rooms.Add(room);


                Room room2 = new Room();
                room2.RoomNumber = 11;
                room2.Description = "Стая с гледка към басейна, с три единични легла.";
                room2.Price = 200;
                room2.RoomTypeId = 2;
                dbContext.Add(room2);


                Room room3 = new Room();
                room3.RoomNumber = 12;
                room3.Description = "Стая с две единични легла.";
                room3.Price = 100;
                room3.RoomTypeId = 2;
                dbContext.Add(room3);
                
                Room flat = new Room();
                flat.RoomNumber = 13;
                flat.Description = "Апартамент с кралско легло и две единични легла, с гледка към морето.";
                flat.Price = 500;
                flat.RoomTypeId = 2;
                dbContext.Rooms.Add(flat);
                
                Room flat2 = new Room();
                flat2.RoomNumber = 14;
                flat2.Description = "Апартамент с гледка към морето и басейна с 2 кралски легла и 2 единични.";
                flat2.Price = 700;
                flat2.RoomTypeId = 4;
                dbContext.Add(flat2);

                Room flat3 = new Room();
                flat3.RoomNumber = 15;
                flat3.Description = "Апартамент с шест единични легла, с мини бар, с вана, с две бани.";
                flat3.Price = 1000;
                flat3.RoomTypeId = 4;
                dbContext.Add(flat3);
                
                #endregion
                #region Floor 2
                Room room4 = new Room();
                room4.RoomNumber = 20;
                room4.Description = "Стая с три единични легла, и вана.";
                room4.Price = 100;
                room4.RoomTypeId = 2;
                dbContext.Rooms.Add(room4);

                Room room5 = new Room();
                room5.RoomNumber = 21;
                room5.Description = "Стая с две двойни легламини и бар.";
                room5.Price = 150;
                room5.RoomTypeId = 1;
                dbContext.Rooms.Add(room5);

                Room room6 = new Room();
                room6.RoomNumber = 22;
                room6.Description = "Стая с две кралски легла, с мини бар и две бани.";
                room6.Price = 400;
                room6.RoomTypeId = 3;
                dbContext.Rooms.Add(room6);

                Room room7 = new Room();
                room7.RoomNumber = 23;
                room7.Description = "Стая с две двойни легла.";
                room7.Price = 50;
                room7.RoomTypeId = 1;
                dbContext.Rooms.Add(room7);

                Room room8 = new Room();
                room8.RoomNumber = 24;
                room8.Description = "Стая с гледка към басейна, с три единични легла.";
                room8.Price = 200;
                room8.RoomTypeId = 2;
                dbContext.Rooms.Add(room8);

                Room flat4 = new Room();
                flat4.RoomNumber = 25;
                flat4.Description = "Апартамент с три единични легла и две бани, с вани.";
                flat4.Price = 300;
                flat4.RoomTypeId = 2;
                dbContext.Rooms.Add(flat4);
                #endregion
                #region Floor 3
                Room room9 = new Room();
                room9.RoomNumber = 30;
                room9.Description = "Стая в таванското помештение.";
                room9.Price = 50;
                room9.RoomTypeId = 1;
                dbContext.Rooms.Add(room9);

                Room flat5 = new Room();
                flat5.RoomNumber = 31;
                flat5.Description = "Апартамент с четири единични легла и две бани.";
                flat5.Price = 249;
                flat5.RoomTypeId = 3;
                dbContext.Rooms.Add(flat5);

                Room flat6 = new Room();
                flat6.RoomNumber = 32;
                flat6.Description = "Апартамент с две единични легла с две бани";
                flat6.Price = 300;
                flat6.RoomTypeId = 1;
                dbContext.Rooms.Add(flat6);

                Room flat7 = new Room();
                flat7.RoomNumber = 33;
                flat7.Description = "Апартамент с три единични легла и две бани.";
                flat7.Price = 400;
                flat7.RoomTypeId = 2;
                dbContext.Rooms.Add(flat7);

                Room flat8 = new Room();
                flat8.RoomNumber = 34;
                flat8.Description = "Апартамент с едно кралско легло, с четири единични легла, с три бани, с две тераси.";
                flat8.Price = 700;
                flat8.RoomTypeId = 4;
                dbContext.Rooms.Add(flat8);

                Room flat9 = new Room();
                flat9.RoomNumber = 35;
                flat9.Description = "Апартамент с пет кралски легла с гледка към морето, басейна, с бар, кухня с готварски прибори, с 4 бани, с 3 телевизора, с рутер в стаята, безплатен масаж, румсервиз, с три тераси, вътрешен басейн в една от баните.";
                flat9.Price = 3000;
                flat9.RoomTypeId = 3;
                dbContext.Rooms.Add(flat9);
                #endregion
                dbContext.SaveChanges();
            }
        }
        public void AddMenuVarieties()
        {
            MenuVariety menuVariety = new MenuVariety();
            menuVariety.Name = "VIP";
            menuVariety.Description = "Напиши!";
            menuVariety.Price = 0;//"Напиши!"
            dbContext.MenuVarieties.Add(menuVariety);

            MenuVariety menuVariety2 = new MenuVariety();
            menuVariety2.Name = "All Inclusive";
            menuVariety2.Description = "Напиши!";
            menuVariety2.Price = 0;//"Напиши!"
            dbContext.MenuVarieties.Add(menuVariety2);

            MenuVariety menuVariety3 = new MenuVariety();
            menuVariety3.Name = "Buffet"; //Блок маса
            menuVariety3.Description = "Напиши! Без напитки!";
            menuVariety3.Price = 0;//"Напиши!"
            dbContext.MenuVarieties.Add(menuVariety3);

            MenuVariety menuVariety4 = new MenuVariety();
            menuVariety4.Name = "With menus";
            menuVariety4.Description = "Напиши!";
            menuVariety4.Price = 0;//"Напиши!"
            dbContext.MenuVarieties.Add(menuVariety4);

            dbContext.SaveChanges();
        }
        public void AddReservation(Reservation reservation)
        {
            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
        }
        public void AddClients(List<Client> clients, Reservation reservation)
        {
            foreach (var client in clients)
            {
                if (client.ReservationId == reservation.Id)
                {
                    if (reservation.IsActive)
                    {
                        UpdateRoomsStatus(client);
                        dbContext.Clients.Add(client);
                    }
                }
            }
            dbContext.SaveChanges();
        }
        public void UpdateRoomsStatus(Client client)
        {
            var clientRoom = dbContext.Rooms.FirstOrDefault(r => r.Id == client.RoomId);
            clientRoom!.IsBooked = true;
            dbContext.SaveChanges();
        }
        public void UpdateReservationAndRoomStatus(Reservation reservation = null!)
        {
            if (reservation != null)
            {
                reservation!.IsActive = false;
                dbContext.SaveChanges();
            }
            else
            {
                var expiredReservations = dbContext.Reservations
                    .Where(r => r.ExpiredOn == DateTime.Today).ToList();
                foreach (var res in expiredReservations)
                {
                    res.IsActive = false;
                }
            }
        }
        public List<Room> GetAllRooms()
        {
            var allRooms = dbContext.Rooms.ToList();
            return allRooms;
        }
        public List<Client> GetAllClients()
        {
            var allClients = dbContext.Clients.ToList();
            return allClients;
        }
        public List<MenuVariety> GetAllMenuVarieties()
        {
            return dbContext.MenuVarieties.ToList();
        }
    }
}
