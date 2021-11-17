using SinusSkateboards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Data
{
    public class CartManager 
    {
        public static List<ProductModel> ShoppingCart { get; set; } = new List<ProductModel>();
        public static List<ProductModel> Products { get; set; }
        public static ProductModel Product { get; set; }
        public static double TotalAmount { get; set; }

        /// <summary>
        /// Adds selected products to shopping cart & makes sure product isn't duplicated
        /// </summary>
        /// <param name="id"></param>
        /// <returns> A list of product in shopping cart </returns>
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
        /// <summary>
        /// Adds product price in TotalAmount 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Total price amount of the shopping cart </returns>
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
        /// <summary>
        /// Subtracts specific product price from TotalAmount
        /// </summary>
        /// <param name="id"></param>
        public static void SubtractCost(int id)
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.ID == id).ToList();

            foreach (var item in Products)
            {
                TotalAmount -= item.Price;
            }
        }
        /// <summary>
        /// Clears shopping cart of products
        /// </summary>
        public static void ClearShoppingCart()
        {
            Products = ProductManager.GetProducts();
            Products = Products.Where(item => item.CartQuantity > 0).ToList();
            foreach (var item in Products)
            {
                item.MaxStock -= item.CartQuantity; // Update MaxStock to be correct after buying products
                item.CartQuantity = 0;
            }
            TotalAmount = 0;
            ShoppingCart = new List<ProductModel>();
        }
        /// <summary>
        /// Subtract product from shopping cart
        /// </summary>
        /// <param name="id"></param>
        public static void SubtractFromCart(int id)
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
