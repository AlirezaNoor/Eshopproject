using System;

namespace Sabzishop.Models.Discount
{
    public class Descount
    {
        public long id { get; set; }
        public DateTime  now { get; set; }
        public DateTime  enddes { get; set; }
        public decimal pricedes { get; set; }
        public long proid { get; set; }

        public Products.Products Products { get; set; }
    }
}
