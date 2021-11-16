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
    public class SearchModel : PageModel
    {
        public string Search { get; set; }
        public List<ProductModel> Products { get; set; }
        public void OnGet(string search)
        {
            Search = search;
            Products = ProductManager.GetProducts();
            // Checks for search through objects SearchTerm property
            Products = Products.Where(item => item.SearchTerm.Contains(search)).ToList();
        }
    }
}
