using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sabzishop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sabzishop.Db_Context;
using Sabzishop.Models.BASKET;
using Sabzishop.Models.Pagination;
using Sabzishop.Models.Products;
using Sabzishop.ViewModel;

namespace Sabzishop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDb _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(MyDb context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
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
        [HttpGet]
        public async Task<IActionResult> Regesture()
        {
 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Regesture(Class model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new IdentityUser()
            {
                UserName = model.name,
                Email = model.Email,
                EmailConfirmed = true,

            };
            var result = await _userManager.CreateAsync(user,model.password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("",err.Description);
                }
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result=await _signInManager.PasswordSignInAsync(model.name, model.password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
      
        }
  
        public async Task<IActionResult> cartshop( string user,long kala)
        {
            var my = await _userManager.FindByNameAsync(user);
            var id=my.Id;
            var prodouct = _context.products.FirstOrDefault(x => x.id == kala);
            var save = new Basket()
            {
                name = prodouct.name,
                userid = id,
                price = prodouct.price,
                proid = prodouct.id,
                tedad = 1,
            };
            _context.Add(save);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost] 
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
