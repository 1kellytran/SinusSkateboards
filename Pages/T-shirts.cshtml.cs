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
    public class T_shirtsModel : PageModel
    {
        public IEnumerable<ProductModel> Tshirts { get; set; }
        public void OnGet()
        {
            Tshirts = ProductManager.GetProducts();
            //Tshirts = Tshirts.Where(item => item.Category == Category.Tshirt).ToList();
            Tshirts = from item in Tshirts
                      where item.Category is Category.Tshirt
                      select item;
        }
    }
}

