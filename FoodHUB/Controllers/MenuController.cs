using System.Collections.Generic;
using System.Web.Mvc;
using FoodHUB.Models;

namespace FoodHUB.Controllers
{
    public class MenuController : Controller
    {
        // GET: /Menu
        public ActionResult Index()
        {
            ViewBag.Title = "Menu";
            var items = GetMenuItems();
            return View(items);
        }

        private List<FoodItem> GetMenuItems()
        {
            return new List<FoodItem>
            {
                // --- Starters ---
                new FoodItem { Id = 1,  Name = "Burrata & Heritage Tomatoes",    Category = "Starters", Price = 14.99m, IsVegetarian = true,  IsPopular = true,  ImageClass = "mi-burrata",   Description = "Creamy burrata served with heirloom tomatoes, fresh basil, aged balsamic, and cold-pressed olive oil." },
                new FoodItem { Id = 2,  Name = "Crispy Calamari",                Category = "Starters", Price = 13.49m, IsVegetarian = false, IsPopular = false, ImageClass = "mi-calamari",  Description = "Golden-fried squid rings with a light seasoned crumb, served with lemon aioli and marinara." },
                new FoodItem { Id = 3,  Name = "Roasted Red Pepper Soup",        Category = "Starters", Price = 10.99m, IsVegetarian = true,  IsPopular = false, ImageClass = "mi-soup",      Description = "Silky roasted red pepper and tomato soup, finished with crème fraîche and sourdough croutons." },
                new FoodItem { Id = 4,  Name = "Chicken Satay Skewers",          Category = "Starters", Price = 12.99m, IsVegetarian = false, IsSpicy = true,   IsPopular = false, ImageClass = "mi-satay",     Description = "Marinated chicken skewers grilled over charcoal, served with a spicy peanut dipping sauce." },

                // --- Mains ---
                new FoodItem { Id = 5,  Name = "Pan-Seared Atlantic Salmon",     Category = "Mains",    Price = 28.99m, IsVegetarian = false, IsPopular = true,  ImageClass = "mi-salmon",    Description = "Crispy-skinned salmon fillet on a pea and mint purée with sautéed asparagus and lemon butter." },
                new FoodItem { Id = 6,  Name = "Mushroom & Lentil Wellington",   Category = "Mains",    Price = 22.99m, IsVegetarian = true,  IsPopular = false, ImageClass = "mi-wellington",Description = "Golden puff-pastry parcel filled with wild mushrooms, Puy lentils, spinach, and roasted garlic." },
                new FoodItem { Id = 7,  Name = "Thai Green Curry",               Category = "Mains",    Price = 20.99m, IsVegetarian = false, IsSpicy = true,   IsPopular = false, ImageClass = "mi-curry",     Description = "Coconut milk green curry with free-range chicken, bamboo shoots, and Thai basil. Served with jasmine rice." },

                // --- Pasta ---
                new FoodItem { Id = 8,  Name = "Creamy Truffle Linguine",        Category = "Pasta",    Price = 24.99m, IsVegetarian = true,  IsPopular = true,  ImageClass = "mi-linguine",  Description = "Hand-rolled linguine tossed in a rich black truffle cream sauce with shaved parmesan." },
                new FoodItem { Id = 9,  Name = "Lobster Tagliatelle",            Category = "Pasta",    Price = 34.99m, IsVegetarian = false, IsPopular = false, ImageClass = "mi-lobster",   Description = "Fresh tagliatelle with half-lobster, cherry tomatoes, chilli, garlic, and a bisque-infused olive oil." },
                new FoodItem { Id = 10, Name = "Pappardelle Bolognese",          Category = "Pasta",    Price = 19.99m, IsVegetarian = false, IsPopular = false, ImageClass = "mi-bolognese", Description = "Slow-cooked beef and pork ragù with fresh pappardelle, topped with aged parmesan and fresh herbs." },

                // --- Grill ---
                new FoodItem { Id = 11, Name = "Prime Wagyu Ribeye 250g",        Category = "Grill",    Price = 54.99m, IsVegetarian = false, IsPopular = true,  ImageClass = "mi-wagyu",     Description = "A5 Wagyu ribeye, chargrilled and rested, served with roasted bone marrow and red wine jus." },
                new FoodItem { Id = 12, Name = "Char-Grilled Lamb Chops",        Category = "Grill",    Price = 36.99m, IsVegetarian = false, IsPopular = false, ImageClass = "mi-lamb",      Description = "Rack of New Zealand lamb with rosemary and garlic crust, served with minted pea mash." },
                new FoodItem { Id = 13, Name = "BBQ Spatchcock Chicken",         Category = "Grill",    Price = 24.99m, IsVegetarian = false, IsSpicy = true,   IsPopular = false, ImageClass = "mi-chicken",   Description = "Half-spatchcock chicken in a smoky chipotle marinade, grilled and served with corn salsa." },

                // --- Desserts ---
                new FoodItem { Id = 14, Name = "Dark Chocolate Fondant",         Category = "Desserts", Price = 12.99m, IsVegetarian = true,  IsPopular = true,  ImageClass = "mi-fondant",   Description = "Warm molten chocolate fondant with a salted caramel core and vanilla bean ice cream." },
                new FoodItem { Id = 15, Name = "Crème Brûlée",                   Category = "Desserts", Price = 10.99m, IsVegetarian = true,  IsPopular = false, ImageClass = "mi-brulee",    Description = "Classic vanilla crème brûlée with a perfectly caramelised sugar crust. Served with shortbread." },
                new FoodItem { Id = 16, Name = "Mango & Passion Fruit Pavlova",  Category = "Desserts", Price = 11.49m, IsVegetarian = true,  IsPopular = false, ImageClass = "mi-pavlova",   Description = "Crisp meringue with whipped cream, fresh mango, passion fruit, and toasted coconut flakes." },

                // --- Drinks ---
                new FoodItem { Id = 17, Name = "Freshly Squeezed Orange Juice",  Category = "Drinks",   Price = 5.49m,  IsVegetarian = true,  IsPopular = false, ImageClass = "mi-oj",        Description = "Made to order from Valencia oranges. Served chilled." },
                new FoodItem { Id = 18, Name = "House Lemonade",                 Category = "Drinks",   Price = 4.99m,  IsVegetarian = true,  IsPopular = false, ImageClass = "mi-lemonade",  Description = "Sparkling lemonade with fresh mint, elderflower cordial, and a hint of ginger." },
                new FoodItem { Id = 19, Name = "Craft Espresso Martini",         Category = "Drinks",   Price = 12.99m, IsVegetarian = true,  IsPopular = true,  ImageClass = "mi-martini",   Description = "Single-origin espresso, premium vodka, coffee liqueur, and a touch of vanilla syrup." },
            };
        }
    }
}
