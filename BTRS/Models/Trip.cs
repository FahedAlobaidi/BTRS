using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        public string Destination { get; set;}

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } 

        public int BusNum { get; set; }

        public ICollection<Bus> Buss { get; set; }

        [ForeignKey("AdminId")]
        public Admin Admins { get; set; }

        public ICollection<Trip_Pass> Trip_Passs { get; set; }
    }
}
