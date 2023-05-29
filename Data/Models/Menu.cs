using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Data.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [ForeignKey("MenyVariety")]
        public int MenuVarietyId { get; set; }
        public virtual ICollection<MenuVariety>? MenuVarieties { get; set; }
        [ForeignKey("MenuOption")]
        public int MenuOptionId { get; set; }
        public virtual ICollection<MenuOption>? MenuOptions { get; set; }
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
