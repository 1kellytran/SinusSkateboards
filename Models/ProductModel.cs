using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
        public string Image { get; set; }
        public string Info { get; set; }
        public Category Category { get; set; }
        public Color Color { get; set; }
        public bool IsBestseller { get; set; } // For selected products on home page
        public int Stock { get; set; } // Currently in stock
        public int MaxStock { get; set; } // To not be able to sell more than this many
        public int CartQuantity { get; set; } // Quantity of a product in shopping cart
        public string SearchTerm { get { return string.Concat(Name.ToLower(), Info.ToLower()); } } // Searchbar
    }
}
