using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sabzishop.Db_Context;

namespace Sabzishop.ViewComponents.Home
{
    public class MobileAndTablet:ViewComponent
    {
        private readonly MyDb _context;

        public MobileAndTablet(MyDb context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.products.Where(s => s.categoryid == 3).ToList();
            return View("MobileAndTablet",model);
        }
    }
}
