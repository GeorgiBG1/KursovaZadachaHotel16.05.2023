using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int RoomTypeId { get; set; }
        public virtual ICollection<RoomType>? RoomTypes { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        public bool IsBooked { get; set; }
    }
}
