using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sabzishop.Db_Context;

namespace Sabzishop.ViewComponents.Home
{
  
    public class AllCategory:ViewComponent
    {
        private readonly MyDb _context;

        public AllCategory(MyDb context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.categories.ToList();
            return View("AllCategory",model);
        }
    }
}
