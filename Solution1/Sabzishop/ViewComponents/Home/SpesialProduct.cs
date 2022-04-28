using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sabzishop.Db_Context;

namespace Sabzishop.ViewComponents.Home
{
    public class SpesialProduct:ViewComponent
    {

        private readonly MyDb _context;

        public SpesialProduct(MyDb context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.products.Where(x => x.ISspesial).ToList();
            return View("SpesialProduct",model);
        }
    }
}
