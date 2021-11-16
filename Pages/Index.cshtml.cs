using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SinusSkateboards.Data;
using SinusSkateboards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Pages
{
    public class IndexModel : PageModel
    {
        public string StartImage = "sinus-logo-symbol - large.png";
        public List<ProductModel> Bestsellers { get; set; }
        [BindProperty]
        public string Search { get; set; }
        public void OnGet()
        {
            Bestsellers = ProductManager.GetProducts();
            // Sorting out bestsellers
            Bestsellers = Bestsellers.Where(item => item.IsBestseller == true).ToList();
        }
        // Initializing search if used
        public IActionResult OnPost()
        {
            return RedirectToPage("/Search", new { Search });
        }
    }
}
