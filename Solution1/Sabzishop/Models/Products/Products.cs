using System.Collections.Generic;
using Sabzishop.Models.BASKET;
using Sabzishop.Models.Discount;

namespace Sabzishop.Models.Products
{
    public class Products
    {
        public long id { get; set; }
        public string name { get; set; }
        public long categoryid { get; set; }
        public string discriptio { get; set; }
        public decimal price { get; set; }
        public long instroe { get; set; }
        public bool ISspesial { get; set; }
        public long descountid { get; set; }
        public Category.Category Category { get; set; }
        public Descount descount { get; set; }
        public List<Basket> basket { get; set; }
    }
}
