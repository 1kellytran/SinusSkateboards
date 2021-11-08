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
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Material Material { get; set; }
    }
}
