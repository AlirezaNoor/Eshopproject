using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.ViewComponents.Home
{
    public class AllCategory:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AllCategory");
        }
    }
}
