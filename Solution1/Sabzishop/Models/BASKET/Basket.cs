using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Sabzishop.Models.BASKET
{
    public class Basket
    {
        public long id { get; set; }
        public string name { get; set; }
        public long tedad { get; set; }
        public decimal price { get; set; }
        public long proid { get; set; }
        public Products.Products Products { get; set; }
        public string userid { get; set; }
        public IdentityUser User   { get; set; }
    }
}
