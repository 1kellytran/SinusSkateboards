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
    public class ViewPageModel : PageModel
    {
        [BindProperty]
        public List<ProductModel> Product { get; set; }
        public void OnGet(int id)
        {
            Product = ProductManager.GetProducts();
            Product = Product.Where(item => item.ID == id).ToList();
            
        }
    }
}
