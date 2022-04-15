using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sabzishop.Db_Context;
using Sabzishop.ViewModel;

namespace Sabzishop.ViewComponents.Home
{
    public class Slider:ViewComponent
    {
        private readonly MyDb _context;

        public Slider(MyDb context)
        {
            _context = context;
        }

        public  IViewComponentResult Invoke()
        {

            var sliders = _context.slider.OrderByDescending(x => x.id).Take(3).ToList();
            
 
            return View("Slider",sliders);
        }
    }
}
