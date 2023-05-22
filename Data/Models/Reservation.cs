using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaHotel.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime BookedOn { get; set; }
        public DateTime ExpiredOn { get; set; }
        public virtual int Duration => BookedOn.Day + ExpiredOn.Day;
        public virtual ICollection<Client>? Clients { get; set; }
        public int MenuId { get; set; }
        public virtual ICollection<MenuVariety>? MenuVarieties { get; set; } 
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
