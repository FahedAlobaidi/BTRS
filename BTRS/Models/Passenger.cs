using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{

    [Index(nameof(Passenger.Username),IsUnique =true)]
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "shold be inserted")]
        public string Name { get; set; }
        [Required(ErrorMessage = "shold be inserted")]
        public string Email { get; set; }
        [Required(ErrorMessage = "shold be inserted")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
        [Required(ErrorMessage = "shold be inserted")]
        public string Username { get; set; }
        [Required(ErrorMessage = "shold be inserted")]
        public string Password { get; set; }

        public ICollection<Trip_Pass> trip_Passes { get; set; }
    }
}
