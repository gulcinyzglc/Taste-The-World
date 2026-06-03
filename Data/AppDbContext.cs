using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Models;

namespace TasteTheWorld.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Food> Foods { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<BucketList> BucketLists { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1,  Name = "Istanbul",    Country = "Turkey",      CountryFlag = "🇹🇷", Emoji = "🕌", BgColor = "#1a3a5c", ImageUrl = "/images/cities/istanbul.jpg" },
            new City { Id = 2,  Name = "Tokyo",       Country = "Japan",       CountryFlag = "🇯🇵", Emoji = "⛩️", BgColor = "#1a1a2e", ImageUrl = "/images/cities/tokyo.jpg" },
            new City { Id = 3,  Name = "Naples",      Country = "Italy",       CountryFlag = "🇮🇹", Emoji = "🏛️", BgColor = "#006994", ImageUrl = "/images/cities/napoli.jpg" },
            new City { Id = 4,  Name = "Bangkok",     Country = "Thailand",    CountryFlag = "🇹🇭", Emoji = "🛺", BgColor = "#1a4a2e", ImageUrl = "/images/cities/bangkok.jpg" },
            new City { Id = 5,  Name = "Mexico City", Country = "Mexico",      CountryFlag = "🇲🇽", Emoji = "🌵", BgColor = "#3a1a0a", ImageUrl = "/images/cities/mexico-city.jpg" },
            new City { Id = 6,  Name = "Paris",       Country = "France",      CountryFlag = "🇫🇷", Emoji = "🗼", BgColor = "#1a1a4a", ImageUrl = "/images/cities/paris.jpg" },
            new City { Id = 7,  Name = "Madrid",      Country = "Spain",       CountryFlag = "🇪🇸", Emoji = "🐂", BgColor = "#8B0000", ImageUrl = "/images/cities/madrid.jpg" },
            new City { Id = 8,  Name = "Barcelona",   Country = "Spain",       CountryFlag = "🇪🇸", Emoji = "🏖️", BgColor = "#c0392b", ImageUrl = "/images/cities/barcelona.jpg" },
            new City { Id = 9,  Name = "New York",    Country = "USA",         CountryFlag = "🇺🇸", Emoji = "🗽", BgColor = "#2c3e50", ImageUrl = "/images/cities/new-york.jpg" },
            new City { Id = 10, Name = "Dubai",       Country = "UAE",         CountryFlag = "🇦🇪", Emoji = "🏙️", BgColor = "#b5770d", ImageUrl = "/images/cities/dubai.jpg" },
            new City { Id = 11, Name = "Singapore",   Country = "Singapore",   CountryFlag = "🇸🇬", Emoji = "🦁", BgColor = "#c0392b", ImageUrl = "/images/cities/singapore.jpg" },
            new City { Id = 12, Name = "Berlin",      Country = "Germany",     CountryFlag = "🇩🇪", Emoji = "🐻", BgColor = "#2d3436", ImageUrl = "/images/cities/berlin.jpg" },
            new City { Id = 13, Name = "Mumbai",      Country = "India",       CountryFlag = "🇮🇳", Emoji = "🕍", BgColor = "#6c3483", ImageUrl = "/images/cities/mumbai.jpg" },
            new City { Id = 14, Name = "Lima",        Country = "Peru",        CountryFlag = "🇵🇪", Emoji = "🦙", BgColor = "#1e8449", ImageUrl = "/images/cities/lima.jpg" },
            new City { Id = 15, Name = "Marrakech",   Country = "Morocco",     CountryFlag = "🇲🇦", Emoji = "🏜️", BgColor = "#784212", ImageUrl = "/images/cities/marakes.jpg" }
        );

        modelBuilder.Entity<Food>().HasData(
            // ISTANBUL
            new Food { Id = 1,  Name = "Balik Ekmek",        Description = "Istanbul's legendary street food. Fresh grilled fish served with salad and lemon at the Galata Bridge.", Emoji = "🥙", Rating = 4.6, ReviewCount = 512, PriceRange = "₺",    Category = "Street Food",   CityId = 1, ImageUrl = "/images/foods/balik-ekmek.jpg" },
            new Food { Id = 2,  Name = "Kunefe",              Description = "A legendary dessert from Antep. Thin kadaif pastry filled with fresh cheese and soaked in sweet syrup, served hot.", Emoji = "🍮", Rating = 4.7, ReviewCount = 452, PriceRange = "₺₺",   Category = "Dessert",       CityId = 1, ImageUrl = "/images/foods/kunefe.jpg" },
            new Food { Id = 3,  Name = "Iskender Kebab",      Description = "The famous kebab of Bursa. Döner meat served with melted butter, tomato sauce, and yogurt.", Emoji = "🥗", Rating = 4.8, ReviewCount = 634, PriceRange = "₺₺",   Category = "Meat Dish",     CityId = 1, ImageUrl = "/images/foods/iskender.jpg" },
            new Food { Id = 4,  Name = "Stuffed Mussels",     Description = "An Istanbul street staple. Mussels stuffed with spiced rice, squeezed with lemon before eating.", Emoji = "🦪", Rating = 4.4, ReviewCount = 389, PriceRange = "₺",    Category = "Street Food",   CityId = 1, ImageUrl = "/images/foods/midye.jpg" },
            new Food { Id = 5,  Name = "Simit",               Description = "The iconic Turkish bagel. Crispy, sesame-coated ring-shaped bread fresh from the oven.", Emoji = "🥯", Rating = 4.5, ReviewCount = 720, PriceRange = "₺",    Category = "Street Food",   CityId = 1, ImageUrl = "/images/foods/simit.jpg", IsVegetarian = true },

            // TOKYO
            new Food { Id = 6,  Name = "Tonkotsu Ramen",      Description = "The soul of Tokyo. Rich pork bone broth simmered for hours, served with thin noodles, egg, and char siu.", Emoji = "🍜", Rating = 4.7, ReviewCount = 781, PriceRange = "€€€",  Category = "Soup",          CityId = 2, ImageUrl = "/images/foods/ramen.jpg" },
            new Food { Id = 7,  Name = "Sushi Omakase",       Description = "A chef's selection of fresh fish and rice combinations. Tokyo's most prestigious dining experience.", Emoji = "🍣", Rating = 4.9, ReviewCount = 345, PriceRange = "€€€€", Category = "Seafood",       CityId = 2, ImageUrl = "/images/foods/sushi.jpg" },
            new Food { Id = 8,  Name = "Yakitori",            Description = "Charcoal-grilled chicken skewers. Served with tare sauce or salt, pairs perfectly with a cold beer.", Emoji = "🍢", Rating = 4.5, ReviewCount = 456, PriceRange = "€€",   Category = "Grilled",       CityId = 2, ImageUrl = "/images/foods/yakitori.jpg" },
            new Food { Id = 9,  Name = "Takoyaki",            Description = "Small balls filled with octopus pieces. Served with okonomiyaki sauce, mayo, and bonito flakes.", Emoji = "🐙", Rating = 4.6, ReviewCount = 523, PriceRange = "€",    Category = "Street Food",   CityId = 2, ImageUrl = "/images/foods/takoyaki.jpg" },

            // NAPLES
            new Food { Id = 10, Name = "Pizza Napoletana",    Description = "The original Neapolitan pizza. Baked in a wood-fired oven in 90 seconds, with San Marzano tomatoes and buffalo mozzarella.", Emoji = "🍕", Rating = 4.8, ReviewCount = 943, PriceRange = "€€",   Category = "Pizza",         CityId = 3, ImageUrl = "/images/foods/pizza.jpg", IsVegetarian = true },
            new Food { Id = 11, Name = "Sfogliatella",        Description = "Naples' iconic shell-shaped pastry. Crispy dough filled with ricotta and orange zest.", Emoji = "🥐", Rating = 4.6, ReviewCount = 312, PriceRange = "€",    Category = "Bakery",        CityId = 3, ImageUrl = "/images/foods/sfogliatella.jpg", IsVegetarian = true },
            new Food { Id = 12, Name = "Spaghetti alle Vongole", Description = "Naples' seafood pasta made with fresh clams, garlic, white wine, and parsley.", Emoji = "🍝", Rating = 4.7, ReviewCount = 428, PriceRange = "€€€",  Category = "Pasta",         CityId = 3, ImageUrl = "/images/foods/vongole.jpg" },

            // BANGKOK
            new Food { Id = 13, Name = "Pad Thai",            Description = "Thailand's national dish. Rice noodles stir-fried with shrimp, egg, peanuts, and tamarind sauce.", Emoji = "🍝", Rating = 4.6, ReviewCount = 385, PriceRange = "€€",   Category = "Noodles",       CityId = 4, ImageUrl = "/images/foods/pad-thai.jpg", IsSpicy = true },
            new Food { Id = 14, Name = "Tom Yum Soup",        Description = "Thailand's sour and spicy soup. Made with shrimp, lemongrass, galangal, kaffir lime leaves, and chili.", Emoji = "🍲", Rating = 4.7, ReviewCount = 467, PriceRange = "€€",   Category = "Soup",          CityId = 4, ImageUrl = "/images/foods/tom-yum.jpg", IsSpicy = true },
            new Food { Id = 15, Name = "Mango Sticky Rice",   Description = "Thailand's most beloved dessert. Sweet sticky rice topped with fresh mango slices and coconut milk.", Emoji = "🥭", Rating = 4.8, ReviewCount = 534, PriceRange = "€",    Category = "Dessert",       CityId = 4, ImageUrl = "/images/foods/mango-rice.jpg", IsVegetarian = true },

            // MEXICO CITY
            new Food { Id = 16, Name = "Tacos al Pastor",     Description = "Mexico City's most iconic street food. Marinated pork cooked on a vertical spit, served with pineapple and cilantro.", Emoji = "🌮", Rating = 4.5, ReviewCount = 623, PriceRange = "€",    Category = "Street Food",   CityId = 5, ImageUrl = "/images/foods/tacos.jpg" },
            new Food { Id = 17, Name = "Guacamole",           Description = "Mexico's essential sauce made with fresh avocado, tomato, onion, cilantro, and lime.", Emoji = "🥑", Rating = 4.6, ReviewCount = 412, PriceRange = "€",    Category = "Appetizer",     CityId = 5, ImageUrl = "/images/foods/guacamole.jpg", IsVegetarian = true },
            new Food { Id = 18, Name = "Chiles en Nogada",    Description = "Mexico's national dish. Stuffed peppers served with walnut sauce and pomegranate seeds — a colorful feast.", Emoji = "🫑", Rating = 4.7, ReviewCount = 289, PriceRange = "€€€",  Category = "Meat Dish",     CityId = 5, ImageUrl = "/images/foods/chiles.jpg" },

            // PARIS
            new Food { Id = 19, Name = "Croissant",           Description = "Paris' morning ritual. A classic French pastry made with buttery, flaky, golden-layered dough.", Emoji = "🥐", Rating = 4.7, ReviewCount = 892, PriceRange = "€",    Category = "Bakery",        CityId = 6, ImageUrl = "/images/foods/croissant.jpg", IsVegetarian = true },
            new Food { Id = 20, Name = "Boeuf Bourguignon",   Description = "The crown of French cuisine. Beef slow-cooked in Burgundy wine with mushrooms and root vegetables.", Emoji = "🥩", Rating = 4.8, ReviewCount = 334, PriceRange = "€€€€", Category = "Meat Dish",     CityId = 6, ImageUrl = "/images/foods/boeuf.jpg" },
            new Food { Id = 21, Name = "Crème Brûlée",        Description = "An icon of French cuisine. Velvety vanilla custard topped with a caramelized sugar crust.", Emoji = "🍮", Rating = 4.8, ReviewCount = 567, PriceRange = "€€",   Category = "Dessert",       CityId = 6, ImageUrl = "/images/foods/creme-brulee.jpg", IsVegetarian = true },

            // MADRID
            new Food { Id = 22, Name = "Paella",              Description = "Spain's national dish from Valencia. A colorful feast of saffron, seafood, and rice.", Emoji = "🥘", Rating = 4.7, ReviewCount = 612, PriceRange = "€€€",  Category = "Rice Dish",     CityId = 7, ImageUrl = "/images/foods/paella.jpg" },
            new Food { Id = 23, Name = "Jamón Ibérico",       Description = "Spain's pride. Premium ham from acorn-fed black pigs, aged for years to perfection.", Emoji = "🥓", Rating = 4.9, ReviewCount = 445, PriceRange = "€€€€", Category = "Charcuterie",   CityId = 7, ImageUrl = "/images/foods/jamon.jpg" },
            new Food { Id = 24, Name = "Churros con Chocolate", Description = "Madrid's morning treat. Fried dough sticks served with thick hot chocolate.", Emoji = "🍩", Rating = 4.6, ReviewCount = 723, PriceRange = "€",    Category = "Dessert",       CityId = 7, ImageUrl = "/images/foods/churros.jpg", IsVegetarian = true },

            // BARCELONA
            new Food { Id = 25, Name = "Pan con Tomate",      Description = "Catalonia's simplest and most delicious dish. Bread rubbed with tomato, garlic, and olive oil — simplicity at its finest.", Emoji = "🍅", Rating = 4.5, ReviewCount = 398, PriceRange = "€",    Category = "Appetizer",     CityId = 8, ImageUrl = "/images/foods/pan-tomate.jpg", IsVegetarian = true },
            new Food { Id = 26, Name = "Crema Catalana",      Description = "The ancestor of crème brûlée. Catalan custard flavored with cinnamon and lemon zest.", Emoji = "🍮", Rating = 4.7, ReviewCount = 312, PriceRange = "€€",   Category = "Dessert",       CityId = 8, ImageUrl = "/images/foods/crema-catalana.jpg", IsVegetarian = true },

            // NEW YORK
            new Food { Id = 27, Name = "NY Pizza Slice",      Description = "New York's iconic large pizza slice. Thin crust, rich sauce, mozzarella — folding it is mandatory!", Emoji = "🍕", Rating = 4.6, ReviewCount = 1205, PriceRange = "€",   Category = "Pizza",         CityId = 9, ImageUrl = "/images/foods/ny-pizza.jpg" },
            new Food { Id = 28, Name = "Cheesecake",          Description = "New York-style cheesecake. A legendary dessert made with cream cheese, eggs, and sugar on a graham cracker crust.", Emoji = "🎂", Rating = 4.8, ReviewCount = 876, PriceRange = "€€",   Category = "Dessert",       CityId = 9, ImageUrl = "/images/foods/cheesecake.jpg", IsVegetarian = true },
            new Food { Id = 29, Name = "Bagel with Lox",      Description = "A New York icon. Sesame bagel loaded with cream cheese, smoked salmon, capers, and onion.", Emoji = "🥯", Rating = 4.7, ReviewCount = 534, PriceRange = "€€",   Category = "Breakfast",     CityId = 9, ImageUrl = "/images/foods/bagel.jpg" },

            // DUBAI
            new Food { Id = 30, Name = "Al Harees",           Description = "Dubai's traditional dish. Wheat and meat slow-cooked and mashed together — a Ramadan staple.", Emoji = "🍲", Rating = 4.5, ReviewCount = 234, PriceRange = "€€",   Category = "Meat Dish",     CityId = 10, ImageUrl = "/images/foods/harees.jpg" },
            new Food { Id = 31, Name = "Shawarma",            Description = "The Middle Eastern flavor found on every corner of Dubai. Spiced meat with hummus, pickles, and hot sauce in flatbread.", Emoji = "🌯", Rating = 4.6, ReviewCount = 892, PriceRange = "€",    Category = "Street Food",   CityId = 10, ImageUrl = "/images/foods/shawarma.jpg", IsSpicy = true },

            // SINGAPORE
            new Food { Id = 32, Name = "Hainanese Chicken Rice", Description = "Singapore's national dish. Tender poached chicken served with aromatic rice, ginger sauce, and chili.", Emoji = "🍚", Rating = 4.8, ReviewCount = 678, PriceRange = "€",    Category = "Chicken",       CityId = 11, ImageUrl = "/images/foods/chicken-rice.jpg" },
            new Food { Id = 33, Name = "Chilli Crab",         Description = "Singapore's pride. Massive crab cooked in a tomato-chili sauce, served with mantou bread.", Emoji = "🦀", Rating = 4.9, ReviewCount = 445, PriceRange = "€€€€", Category = "Seafood",       CityId = 11, ImageUrl = "/images/foods/chilli-crab.jpg", IsSpicy = true },

            // BERLIN
            new Food { Id = 34, Name = "Currywurst",          Description = "Berlin's symbol. Grilled or fried sausage served with curry sauce and curry powder — an iconic street food.", Emoji = "🌭", Rating = 4.5, ReviewCount = 789, PriceRange = "€",    Category = "Street Food",   CityId = 12, ImageUrl = "/images/foods/currywurst.jpg" },
            new Food { Id = 35, Name = "Berliner Döner",      Description = "Berlin's heritage from Turkish immigrants. Lavash bread filled with fresh vegetables, yogurt, and spiced meat.", Emoji = "🥙", Rating = 4.7, ReviewCount = 934, PriceRange = "€",    Category = "Street Food",   CityId = 12, ImageUrl = "/images/foods/berliner-doner.jpg" },

            // MUMBAI
            new Food { Id = 36, Name = "Butter Chicken",      Description = "India's world-famous dish. Tender chicken floating in a creamy tomato-butter sauce. Perfect with naan bread.", Emoji = "🍛", Rating = 4.8, ReviewCount = 823, PriceRange = "€€",   Category = "Chicken",       CityId = 13, ImageUrl = "/images/foods/butter-chicken.jpg", IsSpicy = true },
            new Food { Id = 37, Name = "Vada Pav",            Description = "Mumbai's burger. A spiced potato fritter in a pav bun, served with chutney — the city's favorite street snack.", Emoji = "🍔", Rating = 4.6, ReviewCount = 567, PriceRange = "₺",    Category = "Street Food",   CityId = 13, ImageUrl = "/images/foods/vada-pav.jpg", IsVegetarian = true, IsSpicy = true },

            // LIMA
            new Food { Id = 38, Name = "Ceviche",             Description = "Peru's pride. Fresh seafood marinated in lime juice, ají amarillo, and red onion — the world's most refreshing dish.", Emoji = "🐟", Rating = 4.9, ReviewCount = 567, PriceRange = "€€€",  Category = "Seafood",       CityId = 14, ImageUrl = "/images/foods/ceviche.jpg" },
            new Food { Id = 39, Name = "Lomo Saltado",        Description = "A Peruvian-Chinese fusion. Beef stir-fried with tomatoes, garlic, soy sauce, and french fries.", Emoji = "🥩", Rating = 4.7, ReviewCount = 389, PriceRange = "€€€",  Category = "Meat Dish",     CityId = 14, ImageUrl = "/images/foods/lomo-saltado.jpg" },

            // MARRAKECH
            new Food { Id = 40, Name = "Tagine",              Description = "Morocco's symbol. Lamb slow-cooked with spices and dried fruits in a conical clay pot.", Emoji = "🫕", Rating = 4.8, ReviewCount = 478, PriceRange = "€€",   Category = "Meat Dish",     CityId = 15, ImageUrl = "/images/foods/tagine.jpg" }
        );

        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, FoodId = 1,  AuthorName = "Ahmet Y.", Stars = 5, Comment = "A must-eat in Istanbul! Having it at the Galata Bridge is a unique experience.", CreatedAt = DateTime.Parse("2026-01-10") },
            new Review { Id = 2, FoodId = 1,  AuthorName = "Sara K.",  Stars = 4, Comment = "Very delicious but it can get crowded in the evenings.", CreatedAt = DateTime.Parse("2026-02-05") },
            new Review { Id = 3, FoodId = 6,  AuthorName = "Mert A.",  Stars = 5, Comment = "Find this ramen in Tokyo, you won't regret it!", CreatedAt = DateTime.Parse("2026-03-12") },
            new Review { Id = 4, FoodId = 10, AuthorName = "Elif D.",  Stars = 5, Comment = "Real Neapolitan pizza tastes completely different. Nothing compares!", CreatedAt = DateTime.Parse("2026-04-01") },
            new Review { Id = 5, FoodId = 38, AuthorName = "Can B.",   Stars = 5, Comment = "Had ceviche in Lima — the best seafood experience of my life!", CreatedAt = DateTime.Parse("2026-04-15") },
            new Review { Id = 6, FoodId = 40, AuthorName = "Zeynep M.",Stars = 5, Comment = "Eating tagine in the streets of Marrakech is a one-of-a-kind experience.", CreatedAt = DateTime.Parse("2026-05-01") }
        );
    }
}



