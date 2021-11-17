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
    public class WheelsModel : PageModel
    {
        public IEnumerable<ProductModel> Wheels { get; set; }
        public void OnGet()
        {
            Wheels = ProductManager.GetProducts();
            Wheels = Wheels.Where(item => item is WheelModel);
        }
    }
}