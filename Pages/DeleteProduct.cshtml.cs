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
    public class DeleteProductModel : PageModel
    {
        public List<ProductModel> Product { get; set; }
        public string Message { get; set; }
        // Parameters sent from Admin-page
        public void OnGet(int id)
        {
            Message = ProductManager.DeleteProduct(id);
        }
    }
}
