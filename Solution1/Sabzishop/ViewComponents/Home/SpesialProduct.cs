using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.ViewComponents.Home
{
    public class SpesialProduct:ViewComponent {


        public IViewComponentResult Invoke()
        {
            return View("SpesialProduct");
        }
    }
}
