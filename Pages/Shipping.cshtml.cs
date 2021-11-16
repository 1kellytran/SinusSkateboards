using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Data;

namespace SinusSkateboards.Pages
{
    [BindProperties]
    public class ShippingModel : PageModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string ShippingOption { get; set; }
        public string PaymentOption { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ShippingOption == "DHL")
            {
                CartManager.TotalAmount += 99;
            }
            else
            {
                CartManager.TotalAmount += 39;
            }
            if(PaymentOption == "Klarna (29 SEK)")
            {
                CartManager.TotalAmount += 29;
            }
            return RedirectToPage("/Confirmation", new { Name, Email, Number, Adress, City, PostalCode, ShippingOption, PaymentOption });
        }
    }
}
