using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sabzishop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sabzishop.Db_Context;
using Sabzishop.Models.Pagination;
using Sabzishop.Models.Products;

namespace Sabzishop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDb _context;

        public HomeController(MyDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(int id )
        {
            var model = _context.products.Include(x=>x.descount).FirstOrDefault(x => x.id == id);
            if (model==null)
            {
                return NotFound();
            }
            return View(model);
        }

        public async Task<IActionResult>Listgroup(int pageNummber=1)
        {
            var model = await Pagination<Products>.CreateAsync(_context.products.Include(x=>x.descount), pageNummber, 5);
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
