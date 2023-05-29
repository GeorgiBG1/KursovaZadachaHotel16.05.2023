using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string? EGN { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        [ForeignKey("Room")]
        [Required]
        public int RoomId { get; set; }
        public virtual ICollection<Room>? Rooms { get; set; }
    }
}
