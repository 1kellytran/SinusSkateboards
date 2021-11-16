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
    [BindProperties]
    public class AdminModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        public void OnGet()
        {
            Products = ProductManager.GetProducts();
        }
        public void OnPost()
        {
            //ProductManager.AddProducts(Name, Price, Info, Image, IsBestseller, Stock);
        }
    }
}
