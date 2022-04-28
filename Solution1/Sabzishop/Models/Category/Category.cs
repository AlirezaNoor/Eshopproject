using System.Collections.Generic;

namespace Sabzishop.Models.Category
{
    public class Category
    {
        public long id { get; set; }
        public string name { get; set; }
        public List<Products.Products> ProductsList { get; set; }
    }
}
