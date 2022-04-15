using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.ViewComponents.Home
{
    public class MobileAndTablet:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("MobileAndTablet");
        }
    }
}
