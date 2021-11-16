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
    public class EditModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
        public int Stock { get; set; }
        public int MaxStock { get; set; }
        public int ID { get; set; }
        public string Message { get; set; }

        // Parameter values sent from Admin-page
        public void OnGet(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();
        }
        public void OnPost()
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == ID).ToList();

            Message = ProductManager.EditProduct(Name, Price, Info, Stock, ID);
        }
    }
}
