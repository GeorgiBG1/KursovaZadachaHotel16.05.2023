using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? SurName { get; set; }
        public int EGN { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
    }
}
