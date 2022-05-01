using System;
using System.ComponentModel.DataAnnotations;

namespace Sabzishop.ViewModel
{
    public class Class
    {
        [Required]
        [Display(Name="نام")]
        public String name { get; set; }
        [Required]
        [Display(Name = "نام")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "رمز")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Display(Name = "تکرار رمز عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(password))]
        public string confirmpassword { get; set; }

    }

}
