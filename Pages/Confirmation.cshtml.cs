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
    public class ConfirmationModel : PageModel
    {
        public List<ProductModel> ShoppingCart { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string ShippingOption { get; set; }
        public string PaymentOption { get; set; }
        public double TotalAmount { get; set; }
        
        // Parameters sent from Shipping-page 
        public void OnGet(string name, string email, string number, string adress, string postalCode, string city, string shippingOption, string paymentOption, int id)
        {
            Name = name;
            Email = email;
            Number = number;
            Adress = adress;
            PostalCode = postalCode;
            City = city;
            ShippingOption = shippingOption;
            PaymentOption = paymentOption;
            TotalAmount = CartManager.TotalAmount;

            CartManager.AddToCart(id);
            ShoppingCart = CartManager.ShoppingCart;
        }
    }
}
