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
        public Reservation()
        {
            Clients = new HashSet<Client>();
        }
        public int Id { get; set; }
        public DateTime BookedOn { get; set; }
        public DateTime ExpiredOn { get; set; }
        public virtual int Duration => ExpiredOn.Day - BookedOn.Day;
        public virtual ICollection<Client>? Clients { get; set; }
        public virtual ICollection<Menu>? Menus { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
