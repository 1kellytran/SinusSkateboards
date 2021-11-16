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
    public class CreateModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Info { get; set; }
        public bool IsBestseller { get; set; }
        public int Stock { get; set; }
        public int ID { get; set; }
        public int MaxStock { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            Products = ProductManager.GetProducts();
        }
        public void OnPost()
        {
            ProductManager.AddProducts(Name, Price, Info, Image, IsBestseller, Stock, ID);
            Message = "The new product has been successfully added!";
        }
    }
}
