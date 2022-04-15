using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.ViewComponents.Home
{
    public class ComputerAndLapTop:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ComputerAndLapTop");
        }
    }
}
