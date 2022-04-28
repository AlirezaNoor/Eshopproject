using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabzishop.Db_Context;

namespace Sabzishop.ViewComponents.Home
{

    public class ComputerAndLapTop:ViewComponent
    {
        private readonly MyDb _context;

        public ComputerAndLapTop(MyDb context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var model = _context.products.Where(x => x.categoryid == 2).Include(x => x.descount).ToList();
            return View("ComputerAndLapTop",model);
        }
    }
}
