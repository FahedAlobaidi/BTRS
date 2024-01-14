using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{

    
    public class Bus
    {
        [Key]
        public int BusId { get; set; }

        public string CaptinName { get; set; }

        public int SeatsNum { get; set; }
        [ForeignKey("TripID")]
        public Trip Trips { get; set; }

        [ForeignKey("AdminId")]
        public Admin Admins { get; set; }

    }
}
