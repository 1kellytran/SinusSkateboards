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
    public class CapsModel : PageModel
    {
        public IEnumerable<ProductModel> Caps { get; set; }
        public void OnGet()
        {
            Caps = ProductManager.GetProducts();
            Caps = Caps.Where(item => item.Category == Category.Cap);
        }
    }
}
