using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    public class Trip_Pass
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PassId")]
        public Passenger Passenger { get; set; }

        [ForeignKey("TripId")]
        public Trip Trip { get; set;}
    }
}
