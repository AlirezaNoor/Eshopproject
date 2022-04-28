using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabzishop.Db_Context;

namespace Sabzishop.ViewComponents.Home
{
    public class Sugest:ViewComponent
    {
        private readonly MyDb _conytext;

        public Sugest(MyDb conytext)
        {
            _conytext = conytext;
        }

        public IViewComponentResult Invoke()
        {
            var kala = _conytext.descount.Include(x => x.Products).Where(x => x.Products.id == x.proid).ToList();
            return View("Sugest",kala);
        }
    }
}
