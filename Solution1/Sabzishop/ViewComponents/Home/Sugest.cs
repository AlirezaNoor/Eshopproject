using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sabzishop.ViewComponents.Home
{
    public class Sugest:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Sugest");
        }
    }
}
