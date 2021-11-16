using SinusSkateboards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Data
{
    public class CartManager 
    {
        public int ShippingCosts { get; set; }
        public static double TotalAmount { get; set; }
        public static List<ProductModel> ShoppingCart { get; set; } = new List<ProductModel>();
        public static List<ProductModel> Products { get; set; }
        public static ProductModel Product { get; set; }

        public static List<ProductModel> AddToCart(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();

            foreach (var item in Products)
            {
                if (ShoppingCart.Contains(item))
                {
                    if(item.CartQuantity < item.MaxStock)
                    {
                        item.CartQuantity += 1;
                        item.Stock -= 1;
                        CartManager.TotalCost(id);
                    }                    
                }
                else
                {
                    item.CartQuantity += 1;
                    item.Stock -= 1;
                    ShoppingCart.Add(item);
                }
            }
            return ShoppingCart = CartManager.ShoppingCart;
        }
        //public static void RemoveFromCart(int id) // VAR SKA DENNA METOD ANROPAS??? TROR INTE DENNA FUNKAR FÖ
        //{
        //    ShoppingCart = ShoppingCart.Where(item => item.ID == id).ToList();
        //    foreach (var item in ShoppingCart)
        //    {
        //        ShoppingCart.Remove(item);
        //    }
        //}
        public static double TotalCost(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();

            foreach (var item in Products)
            {
                TotalAmount += item.Price;
            }
            TotalAmount = CartManager.TotalAmount;
            return TotalAmount;
        }
        public static void SubtractCost(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();

            foreach (var item in Products)
            {
                TotalAmount -= item.Price;
            }
        }
        public static void ClearShoppingCart()
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.CartQuantity > 0).ToList();
            foreach (var item in Products)
            {
                item.MaxStock -= item.CartQuantity;
                item.CartQuantity = 0;
            }
            TotalAmount = 0;
            ShoppingCart = new List<ProductModel>();
        }
        public static void RemoveFromCart(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();

            foreach (var item in Products)
            {
                if (ShoppingCart.Contains(item))
                {
                    if(item.CartQuantity == 1)
                    {
                        ShoppingCart.Remove(item);
                        item.Stock += 1;
                    }
                    else
                    {
                        item.CartQuantity -= 1;
                        item.Stock += 1;
                    }
                }

            }
        }
    }
}
