using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Data;

namespace SinusSkateboards.Pages
{
    public class ThankYouModel : PageModel
    {
        public string StartImage = "sinus-logo-portrait - large.png";
        public void OnGet()
        {
            CartManager.ClearShoppingCart();
        }
    }
}
