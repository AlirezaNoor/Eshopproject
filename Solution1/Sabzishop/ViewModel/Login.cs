using System.ComponentModel.DataAnnotations;

namespace Sabzishop.ViewModel
{
    public class Login
        { 
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
    }
}
