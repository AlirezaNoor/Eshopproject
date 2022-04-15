using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.Models.Slider
{
    public class Slider
    {
        [Required] 
        [Key]
        public long id { get; set; }

        [Required]
        public string title { get; set; }
         [Required]
        public string undertitle { get; set; }
        [Required]
        public string discription { get; set; }
    }
}
