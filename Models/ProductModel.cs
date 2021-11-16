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
        public bool IsBestseller { get; set; }
        public int Stock { get; set; }
        public int MaxStock { get; set; }
        public int CartQuantity { get; set; }
        public string SearchTerm { get { return string.Concat(Name.ToLower(), Info.ToLower()); } }
    }
}
