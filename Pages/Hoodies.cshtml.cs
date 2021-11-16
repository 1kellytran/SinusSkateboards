using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Models;
using SinusSkateboards.Data;

namespace SinusSkateboards.Pages
{
    public class HoodiesModel : PageModel
    {
        public IEnumerable<ProductModel> Hoodies { get; set; }
        public void OnGet()
        {
            Hoodies = ProductManager.GetProducts();
            Hoodies = from item in Hoodies
                      where item.Category is Category.Hoodie
                      select item;
        }
    }
}
