using SinusSkateboards.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinusSkateboards.Data
{
    
    public static class ProductManager
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>();
        public static ProductModel Product { get; set; } 
        public static string AddProducts(string name, double price, string info, string image, bool isBestseller, int stock, int id)
        {
            ProductModel Product = new ProductModel();

            Product.Name = name;
            Product.Price = price;
            Product.Info = info;
            Product.Image = image;
            Product.IsBestseller = isBestseller;
            Product.Stock = stock;
            Product.MaxStock = stock;
            Product.ID = id;

            Products.Add(Product);
            string message = "The new product has been added!";
            return message;
        }

        public static string EditProduct(string name, int price, string info, int stock, int id)
        {
            ProductModel EditedProduct = Products.Where(product => product.ID == id).FirstOrDefault();
            EditedProduct.Name = name;
            EditedProduct.Price = price;
            EditedProduct.Info = info;
            EditedProduct.Stock = stock;
            EditedProduct.MaxStock = stock;

            string message = "Changes has been saved!";
            return message;
        }

        public static string DeleteProduct(int id)
        {
            ProductModel DeletedProduct = Products.Where(product => product.ID == id).FirstOrDefault();
            Products.Remove(DeletedProduct);

            string message = "Product has been deleted.";
            return message;
        }

        public static List<ProductModel> GetProducts()
        {
            if (!Products.Any())
            {
                Products = new List<ProductModel>()
                {
                    new WearableModel()
                    {
                        Name = "Ocean Cap",
                        Price = 199,
                        ID = 100,
                        Image = "sinus-cap-blue.png",
                        Info = "Blue recycled cotton cap",
                        Category = Category.Cap,
                        Size = Size.ONE_SIZE,
                        Color = Color.Blue,
                        Stock = 40,
                        MaxStock = 40,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Forrest Cap",
                        Price = 199,
                        ID = 101,
                        Image = "sinus-cap-green.png",
                        Info = "Green recycled cotton cap",
                        Category = Category.Cap,
                        Size = Size.ONE_SIZE,
                        Color = Color.Green,
                        Stock = 40,
                        MaxStock = 40,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal Cap",
                        Price = 199,
                        ID = 102,
                        Image = "sinus-cap-purple.png",
                        Info = "Purple recycled cotton cap",
                        Category = Category.Cap,
                        Size = Size.ONE_SIZE,
                        Color = Color.Purple,
                        Stock = 40,
                        MaxStock = 40,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Fire Cap",
                        Price = 199,
                        ID = 103,
                        Image = "sinus-cap-red.png",
                        Info = "Red recycled cotton cap",
                        Category = Category.Cap,
                        Size = Size.ONE_SIZE,
                        Color = Color.Red,
                        Stock = 40,
                        MaxStock = 40,
                        IsBestseller = true,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ash Hoodie ",
                        Price = 599,
                        ID = 200,
                        Image = "sinus-hoodie-ash.png",
                        Info = " Cool-ash hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.S,
                        Color = Color.Grey,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ash Hoodie ",
                        Price = 599,
                        ID = 201,
                        Image = "sinus-hoodie-ash.png",
                        Info = " Cool-ash hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.M,
                        Color = Color.Grey,
                        Stock = 30,
                        MaxStock = 30,
                        IsBestseller = true,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ash Hoodie ",
                        Price = 599,
                        ID = 202,
                        Image = "sinus-hoodie-ash.png",
                        Info = " Cool-ash hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.L,
                        Color = Color.Grey,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Fire Hoodie",
                        Price = 599,
                        ID = 203,
                        Image = "sinus-hoodie-fire.png",
                        Info = "Hot hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.S,
                        Color = Color.Red,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Fire Hoodie",
                        Price = 599,
                        ID = 204,
                        Image = "sinus-hoodie-fire.png",
                        Info = "Hot hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.M,
                        Color = Color.Red,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Fire Hoodie",
                        Price = 599,
                        ID = 205,
                        Image = "sinus-hoodie-fire.png",
                        Info = "Hot hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.L,
                        Color = Color.Red,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Forrest Hoodie ",
                        Price = 599,
                        ID = 206,
                        Image = "sinus-hoodie-green.png",
                        Info = "Wild hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.S,
                        Color = Color.Green,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Forrest Hoodie ",
                        Price = 599,
                        ID = 207,
                        Image = "sinus-hoodie-green.png",
                        Info = "Wild hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.M,
                        Color = Color.Green,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Forrest Hoodie ",
                        Price = 599,
                        ID = 208,
                        Image = "sinus-hoodie-green.png",
                        Info = "Wild hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.L,
                        Color = Color.Green,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean Hoodie ",
                        Price = 599,
                        ID = 209,
                        Image = "sinus-hoodie-ocean.png",
                        Info = "Fresh hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.S,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean Hoodie ",
                        Price = 599,
                        ID = 210,
                        Image = "sinus-hoodie-ocean.png",
                        Info = "Fresh hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.M,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean Hoodie ",
                        Price = 599,
                        ID = 211,
                        Image = "sinus-hoodie-ocean.png",
                        Info = "Fresh hoodie made of recycled cotton",
                        Category = Category.Hoodie,
                        Size = Size.L,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal Hoodie ",
                        Price = 599,
                        ID = 212,
                        Image = "sinus-hoodie-purple.png",
                        Info = "Hoodie made of recycled cotton that makes you feel like a king or queen",
                        Category = Category.Hoodie,
                        Size = Size.S,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal Hoodie ",
                        Price = 599,
                        ID = 213,
                        Image = "sinus-hoodie-purple.png",
                        Info = "Hoodie made of recycled cotton that makes you feel like a king or queen",
                        Category = Category.Hoodie,
                        Size = Size.M,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal Hoodie ",
                        Price = 599,
                        ID = 214,
                        Image = "sinus-hoodie-purple.png",
                        Info = "Hoodie made of recycled cotton that makes you feel like a king or queen",
                        Category = Category.Hoodie,
                        Size = Size.L,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Eagle Board",
                        Price = 799,
                        ID = 300,
                        Image = "sinus-skateboard-eagle.png",
                        Info = "Free roaming skatebord",
                        Color = Color.Patterned,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Fire Board",
                        Price = 899,
                        ID = 301,
                        Image = "sinus-skateboard-fire.png",
                        Info = "Lit deck for dare devils",
                        Color = Color.Patterned,
                        Material = Material.Wood,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Greta's Fury",
                        Price = 1199,
                        ID = 302,
                        Image = "sinus-skateboard-gretasfury.png",
                        Info = "Recycled wood deck for furious kids",
                        Color = Color.Patterned,
                        Material = Material.Wood,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Ink Board",
                        Price = 799,
                        ID = 303,
                        Image = "sinus-skateboard-ink.png",
                        Info = "GET INKED!",
                        Color = Color.Patterned,
                        Material = Material.Plastic,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Sinus Board",
                        Price = 899,
                        ID = 304,
                        Image = "sinus-skateboard-logo.png",
                        Info = "Our house deck and bestseller!",
                        Color = Color.Patterned,
                        Material = Material.Wood,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Northern Light Board",
                        Price = 799,
                        ID = 305,
                        Image = "sinus-skateboard-northern_lights.png",
                        Info = "Spaced out skateboard",
                        Color = Color.Patterned,
                        Material = Material.Plastic,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Plastic Fantastic Board",
                        Price = 799,
                        ID = 306,
                        Image = "sinus-skateboard-plastic.png",
                        Info = "Artsy skateboard for diffrent minds",
                        Color = Color.Patterned,
                        Material = Material.Plastic,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Polar Board",
                        Price = 899,
                        ID = 307,
                        Image = "sinus-skateboard-polar.png",
                        Info = "Cool skateboard",
                        Color = Color.Patterned,
                        Material = Material.Wood,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Royal Board",
                        Price = 799,
                        ID = 308,
                        Image = "sinus-skateboard-purple.png",
                        Info = "Skateboard for kings and queens",
                        Color = Color.Purple,
                        Material = Material.Plastic,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new SkateboardModel()
                    {
                        Name = "Lemonade Board",
                        Price = 799,
                        ID = 309,
                        Image = "sinus-skateboard-yellow.png",
                        Info = "Fresh skateboard for sour people",
                        Color = Color.Yellow,
                        Material = Material.Plastic,
                        Stock = 10,
                        MaxStock = 10,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean T-shirt",
                        Price = 299,
                        ID = 400,
                        Image = "sinus-tshirt-blue.png",
                        Info = "Ocean fresh T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.S,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean T-shirt",
                        Price = 299,
                        ID = 401,
                        Image = "sinus-tshirt-blue.png",
                        Info = "Ocean fresh T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.M,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Ocean T-shirt",
                        Price = 299,
                        ID = 402,
                        Image = "sinus-tshirt-blue.png",
                        Info = "Ocean fresh T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.L,
                        Color = Color.Blue,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Charcoal T-shirt",
                        Price = 299,
                        ID = 403,
                        Image = "sinus-tshirt-grey.png",
                        Info = "Tough black T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.S,
                        Color = Color.Black,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Charcoal T-shirt",
                        Price = 299,
                        ID = 404,
                        Image = "sinus-tshirt-grey.png",
                        Info = "Tough black T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.M,
                        Color = Color.Black,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Charcoal T-shirt",
                        Price = 299,
                        ID = 405,
                        Image = "sinus-tshirt-grey.png",
                        Info = "Tough black T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.L,
                        Color = Color.Black,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Barbie T-shirt",
                        Price = 299,
                        ID = 406,
                        Image = "sinus-tshirt-pink.png",
                        Info = "Party pink T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.S,
                        Color = Color.Pink,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Barbie T-shirt",
                        Price = 299,
                        ID = 407,
                        Image = "sinus-tshirt-pink.png",
                        Info = "Party pink T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.M,
                        Color = Color.Pink,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Barbie T-shirt",
                        Price = 299,
                        ID = 408,
                        Image = "sinus-tshirt-pink.png",
                        Info = "Party pink T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.L,
                        Color = Color.Pink,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal T-shirt",
                        Price = 299,
                        ID = 409,
                        Image = "sinus-tshirt-purple.png",
                        Info = "T-shirt for kings and queens\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.S,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal T-shirt",
                        Price = 299,
                        ID = 410,
                        Image = "sinus-tshirt-purple.png",
                        Info = "T-shirt for kings and queens\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.M,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Royal T-shirt",
                        Price = 299,
                        ID = 411,
                        Image = "sinus-tshirt-purple.png",
                        Info = "T-shirt for kings and queens\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.L,
                        Color = Color.Purple,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Lemonade T-shirt",
                        Price = 299,
                        ID = 412,
                        Image = "sinus-tshirt-yellow.png",
                        Info = "Our most sour T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.S,
                        Color = Color.Yellow,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Lemonade T-shirt",
                        Price = 299,
                        ID = 413,
                        Image = "sinus-tshirt-yellow.png",
                        Info = "Our most sour T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.M,
                        Color = Color.Yellow,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WearableModel()
                    {
                        Name = "Lemonade T-shirt",
                        Price = 299,
                        ID = 414,
                        Image = "sinus-tshirt-yellow.png",
                        Info = "Our most sour T-shirt\nBreathable recycled cotton.",
                        Category = Category.Tshirt,
                        Size = Size.L,
                        Color = Color.Yellow,
                        Stock = 30,
                        MaxStock = 30,
                        CartQuantity = 0
                    },
                    new WheelModel()
                    {
                        Name = "Rocket Wheels",
                        Price = 199,
                        ID = 500,
                        Image = "sinus-wheel-rocket.png",
                        Info = "Fast wheel for speedfreaks",
                        WheelSize = WheelSize.Fat,
                        Color = Color.Patterned,
                        Stock = 20,
                        MaxStock = 20,
                        IsBestseller = true,
                        CartQuantity = 0
                    },
                    new WheelModel()
                    {
                        Name = "Spinner Wheels",
                        Price = 199,
                        ID = 501,
                        Image = "sinus-wheel-spinner.png",
                        Info = "Standard wheel",
                        WheelSize = WheelSize.Slim,
                        Color = Color.Patterned,
                        Stock = 20,
                        MaxStock = 20,
                        CartQuantity = 0
                    },
                    new WheelModel()
                    {
                        Name = "Wave Wheels",
                        Price = 199,
                        ID = 502,
                        Image = "sinus-wheel-wave.png",
                        Info = "Soft wheels for slackers",
                        WheelSize = WheelSize.Slim,
                        Color = Color.Patterned,
                        Stock = 20,
                        MaxStock = 20,
                        CartQuantity = 0
                    }
                };
            }
            return Products;
        }
    }
}