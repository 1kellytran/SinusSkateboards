using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Data;
using SinusSkateboards.Models;

namespace SinusSkateboards.Pages
{
    public class SkateboardsModel : PageModel
    {
        public IEnumerable<ProductModel> Skateboards { get; set; }
        public void OnGet()
        {
            Skateboards = ProductManager.GetProducts();
            Skateboards = from item in Skateboards
                          where item is SkateboardModel
                          select item;
        }
    }
}
