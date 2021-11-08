using SinusSkateboards.Models;
using System.Collections.Generic;
using System.Linq;



namespace SinusSkateboards.Data
{
    public static class ProductManager
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>();
        public static List<ShoppingCartModel> ShoppingCart { get; set; } = new List<ShoppingCartModel>();
        public static List<ProductModel> GetProducts()
        {
            if (!Products.Any())
            {
                Products = new List<ProductModel>()
{
                new ProductModel()
                {
                    Name = "Ocean Cap",
                    Price = 199,
                    ID = 100,
                    Image = "sinus-cap-blue.png",
                    Info = "Blue recycled cotton cap",
                    Category = Category.Cap,
                    Size = Size.One_size,
                    Color = Color.Blue
                },
                new ProductModel()
                {
                    Name = "Forrest Cap",
                    Price = 199,
                    ID = 101,
                    Image = "sinus-cap-green.png",
                    Info = "Green recycled cotton cap",
                    Category = Category.Cap,
                    Size = Size.One_size,
                    Color = Color.Green
                },
                new ProductModel()
            {
            Name = "Royal Cap",
            Price = 199,
            ID = 102,
            Image = "sinus-cap-purple.png",
            Info = "Purple recycled cotton cap",
            Category = Category.Cap,
            Size = Size.One_size,
            Color = Color.Purple,



            },
                new ProductModel()
                {
                Name = "Fire Cap",
                Price = 199,
                ID = 103,
                Image = "sinus-cap-red.png",
                Info = "Red recycled cotton cap",
                Category = Category.Cap,
                Size = Size.One_size,
                Color = Color.Red,



                },
                new ProductModel()
                {
                Name = "Ash Hoodie ",
                Price = 599,
                ID = 200,
                Image = "sinus-hoodie-ash.png",
                Info = " Cool-ash hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.S,
                Color = Color.Grey,



                },
                new ProductModel()
                {
                Name = "Ash Hoodie ",
                Price = 599,
                ID = 201,
                Image = "sinus-hoodie-ash.png",
                Info = " Cool-ash hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.M,
                Color = Color.Grey,



                },
                new ProductModel()
                {
                Name = "Ash Hoodie ",
                Price = 599,
                ID = 202,
                Image = "sinus-hoodie-ash.png",
                Info = " Cool-ash hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.L,
                Color = Color.Grey,



                },
                new ProductModel()
                {
                Name = "Fire Hoodie",
                Price = 599,
                ID = 203,
                Image = "sinus-hoodie-fire.png",
                Info = "Hot hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.S,
                Color = Color.Red,



                },
                new ProductModel()
                {
                Name = "Fire Hoodie",
                Price = 599,
                ID = 204,
                Image = "sinus-hoodie-fire.png",
                Info = "Hot hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.M,
                Color = Color.Red,



                },
                new ProductModel()
                {
                Name = "Fire Hoodie",
                Price = 599,
                ID = 205,
                Image = "sinus-hoodie-fire.png",
                Info = "Hot hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.L,
                Color = Color.Red,



                },
                new ProductModel()
                {
                Name = "Forrest Hoodie ",
                Price = 599,
                ID = 206,
                Image = "sinus-hoodie-green.png",
                Info = "Wild hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.S,
                Color = Color.Green,



                },
                new ProductModel()
                {
                Name = "Forrest Hoodie ",
                Price = 599,
                ID = 207,
                Image = "sinus-hoodie-green.png",
                Info = "Wild hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.M,
                Color = Color.Green,



                },
                new ProductModel()
                {
                Name = "Forrest Hoodie ",
                Price = 599,
                ID = 208,
                Image = "sinus-hoodie-green.png",
                Info = "Wild hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.L,
                Color = Color.Green,



                },
                new ProductModel()
                {
                Name = "Ocean Hoodie ",
                Price = 599,
                ID = 209,
                Image = "sinus-hoodie-ocean.png",
                Info = "Fresh hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.S,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Ocean Hoodie ",
                Price = 599,
                ID = 210,
                Image = "sinus-hoodie-ocean.png",
                Info = "Fresh hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.M,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Ocean Hoodie ",
                Price = 599,
                ID = 211,
                Image = "sinus-hoodie-ocean.png",
                Info = "Fresh hoodie made of Recycled cotton",
                Category = Category.Hoodie,
                Size = Size.L,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Royal Hoodie ",
                Price = 599,
                ID = 212,
                Image = "sinus-hoodie-purple.png",
                Info = "Hoodie made of Recycled cotton that makes you feel like a king or queen",
                Category = Category.Hoodie,
                Size = Size.S,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Royal Hoodie ",
                Price = 599,
                ID = 213,
                Image = "sinus-hoodie-purple.png",
                Info = "Hoodie made of Recycled cotton that makes you feel like a king or queen",
                Category = Category.Hoodie,
                Size = Size.M,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Royal Hoodie ",
                Price = 599,
                ID = 214,
                Image = "sinus-hoodie-purple.png",
                Info = "Hoodie made of Recycled cotton that makes you feel like a king or queen",
                Category = Category.Hoodie,
                Size = Size.L,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Eagle Board",
                Price = 2999,
                ID = 300,
                Image = "sinus-skateboard-eagle.png",
                Info = "Free roaming skatebord",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,



                },
                new ProductModel()
                {
                Name = "Eagle Board",
                Price = 2999,
                ID = 300,
                Image = "sinus-skateboard-eagle.png",
                Info = "Free roaming skatebord",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Fire Board",
                Price = 2999,
                ID = 301,
                Image = "sinus-skateboard-fire.png",
                Info = "Lit skteboard for dare devils",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Wood,



                },
                new ProductModel()
                {
                Name = "Gretas Board",
                Price = 4999,
                ID = 302,
                Image = "sinus-skateboard-gretasfury.png",
                Info = "Recycled wood board for furious kids",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Wood,



                },
                new ProductModel()
                {
                Name = "Ink Board",
                Price = 2999,
                ID = 303,
                Image = "sinus-skateboard-ink.png",
                Info = "GET INKED!",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Sinus Board",
                Price = 2999,
                ID = 304,
                Image = "sinus-skateboard-logo.png",
                Info = "Our house board and bestseller!",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Wood,



                },
                new ProductModel()
                {
                Name = "Northern Light Board",
                Price = 2999,
                ID = 305,
                Image = "sinus-skateboard-northern_lights.png",
                Info = "Spaced out skateboard",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Plastic Fantastic Board",
                Price = 2999,
                ID = 306,
                Image = "sinus-skateboard-plastic.png",
                Info = "Artsy Skateboard for diffrent minds",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Polar Board",
                Price = 2999,
                ID = 307,
                Image = "sinus-skateboard-polar.png",
                Info = "Cool skateboard",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Patterned,
                Material = Material.Wood,



                },
                new ProductModel()
                {
                Name = "Royal Board",
                Price = 2999,
                ID = 308,
                Image = "sinus-skateboard-purple.png",
                Info = "Skateboard for kings and queens",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Purple,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Lemonade Board",
                Price = 2999,
                ID = 307,
                Image = "sinus-skateboard-yellow.png",
                Info = "Fresh skateboard for sour people",
                Category = Category.Skateboard,
                Size = Size.One_size,
                Color = Color.Yellow,
                Material = Material.Plastic,



                },
                new ProductModel()
                {
                Name = "Ocean T-shirt",
                Price = 299,
                ID = 400,
                Image = "sinus-tshirt-blue.png",
                Info = "Ocean fresh T-shirt",
                Category = Category.Tshirt,
                Size = Size.S,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Ocean T-shirt",
                Price = 299,
                ID = 401,
                Image = "sinus-tshirt-blue.png",
                Info = "Ocean fresh T-shirt",
                Category = Category.Tshirt,
                Size = Size.M,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Ocean T-shirt",
                Price = 299,
                ID = 402,
                Image = "sinus-tshirt-blue.png",
                Info = "Ocean fresh T-shirt",
                Category = Category.Tshirt,
                Size = Size.L,
                Color = Color.Blue,



                },
                new ProductModel()
                {
                Name = "Charcoal T-shirt",
                Price = 299,
                ID = 403,
                Image = "sinus-tshirt-grey.png",
                Info = "Tough black T-shirt",
                Category = Category.Tshirt,
                Size = Size.S,
                Color = Color.Black,



                },
                new ProductModel()
                {
                Name = "Charcoal T-shirt",
                Price = 299,
                ID = 404,
                Image = "sinus-tshirt-grey.png",
                Info = "Tough black T-shirt",
                Category = Category.Tshirt,
                Size = Size.M,
                Color = Color.Black,



                },
                new ProductModel()
                {
                Name = "Charcoal T-shirt",
                Price = 299,
                ID = 405,
                Image = "sinus-tshirt-grey.png",
                Info = "Tough black T-shirt",
                Category = Category.Tshirt,
                Size = Size.L,
                Color = Color.Black,



                },
                new ProductModel()
                {
                Name = "Barbie T-shirt",
                Price = 299,
                ID = 406,
                Image = "sinus-tshirt-pink.png",
                Info = "Party pink T-shirt",
                Category = Category.Tshirt,
                Size = Size.S,
                Color = Color.Pink,



                },
                new ProductModel()
                {
                Name = "Barbie T-shirt",
                Price = 299,
                ID = 407,
                Image = "sinus-tshirt-pink.png",
                Info = "Party pink T-shirt",
                Category = Category.Tshirt,
                Size = Size.M,
                Color = Color.Pink,



                },
                new ProductModel()
                {
                Name = "Barbie T-shirt",
                Price = 299,
                ID = 408,
                Image = "sinus-tshirt-pink.png",
                Info = "Party pink T-shirt",
                Category = Category.Tshirt,
                Size = Size.L,
                Color = Color.Pink,



                },
                new ProductModel()
                {
                Name = "Royal T-shirt",
                Price = 299,
                ID = 409,
                Image = "sinus-tshirt-purple.png",
                Info = "T-shirt for kings and queens",
                Category = Category.Tshirt,
                Size = Size.S,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Royal T-shirt",
                Price = 299,
                ID = 410,
                Image = "sinus-tshirt-purple.png",
                Info = "T-shirt for kings and queens",
                Category = Category.Tshirt,
                Size = Size.M,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Royal T-shirt",
                Price = 299,
                ID = 411,
                Image = "sinus-tshirt-purple.png",
                Info = "T-shirt for kings and queens",
                Category = Category.Tshirt,
                Size = Size.L,
                Color = Color.Purple,



                },
                new ProductModel()
                {
                Name = "Lemonade T-shirt",
                Price = 299,
                ID = 412,
                Image = "sinus-tshirt-yellow.png",
                Info = "Our most sour T-shirt",
                Category = Category.Tshirt,
                Size = Size.S,
                Color = Color.Yellow,



                },
                new ProductModel()
                {
                Name = "Lemonade T-shirt",
                Price = 299,
                ID = 413,
                Image = "sinus-tshirt-yellow.png",
                Info = "Our most sour T-shirt",
                Category = Category.Tshirt,
                Size = Size.M,
                Color = Color.Yellow,



                },
                new ProductModel()
                {
                Name = "Lemonade T-shirt",
                Price = 299,
                ID = 414,
                Image = "sinus-tshirt-yellow.png",
                Info = "Our most sour T-shirt",
                Category = Category.Tshirt,
                Size = Size.L,
                Color = Color.Yellow,



                },
                new ProductModel()
                {
                Name = "Rocket Wheels",
                Price = 199,
                ID = 500,
                Image = "sinus-wheel-rocket.png",
                Info = "Fast wheel for speedfreaks",
                Category = Category.Wheel,
                Size = Size.One_size,
                Color = Color.Patterned,



                },
                new ProductModel()
                {
                Name = "Spinner Wheels",
                Price = 199,
                ID = 501,
                Image = "sinus-wheel-spinner.png",
                Info = "Standard wheel",
                Category = Category.Wheel,
                Size = Size.One_size,
                Color = Color.Patterned,



                },
                new ProductModel()
                {
                Name = "Wave Wheels",
                Price = 199,
                ID = 502,
                Image = "sinus-wheel-wave.png",
                Info = "Soft wheels for slackers",
                Category = Category.Wheel,
                Size = Size.One_size,
                Color = Color.Patterned,



                }
                };
            }
            return Products;
        }
    }



}