using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
	public class Login
	{
		[Required(ErrorMessage ="please fill the userName")]
		public string userName {  get; set; }
		[Required(ErrorMessage ="please fill the password")]
		public string password { get; set; }
	}
}
