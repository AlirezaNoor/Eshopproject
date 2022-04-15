using System.ComponentModel.DataAnnotations;

namespace Sabzishop.ViewModel
{
    public class SliderVm
    {
        [Required]
       
        public long id { get; set; }

        [Required]
        public string title { get; set; }
        [Required]
        public string undertitle { get; set; }
        [Required]
        public string discription { get; set; }
    }
}
 
