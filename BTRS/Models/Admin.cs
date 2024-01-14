using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTRS.Models
{
    [Index(nameof(Admin.Username),IsUnique =true)]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }
        [Required(ErrorMessage ="shold be inserted")]
        public string Password { get; set; }

        public ICollection<Bus> Buss { get; set; }  

        public ICollection<Trip> Trips { get; set; }
        
    }
}
