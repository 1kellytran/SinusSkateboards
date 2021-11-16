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
    public class ShoppingCartModel : PageModel
    {
        public List<ProductModel> ShoppingCart { get; set; }
        public double TotalAmount { get; set; }
        // Parameters sent from VewProduct-page
        public void OnGet(int id)
        {
            ShoppingCart = CartManager.AddToCart(id);
            CartManager.TotalCost(id);
            TotalAmount = CartManager.TotalAmount;
        }
        public void OnPost(int id, string action)
        {
            if(action == "Add")
            {
                CartManager.AddToCart(id);
            }
            else if(action == "Remove")
            {
                CartManager.RemoveFromCart(id);
                CartManager.SubtractCost(id);
            }
            ShoppingCart = CartManager.ShoppingCart;
            TotalAmount = CartManager.TotalAmount;
        }
    }
}
