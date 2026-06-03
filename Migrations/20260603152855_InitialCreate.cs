using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasteTheWorld.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    CountryFlag = table.Column<string>(type: "TEXT", nullable: false),
                    Emoji = table.Column<string>(type: "TEXT", nullable: false),
                    BgColor = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Emoji = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    ReviewCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceRange = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    IsSpicy = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "INTEGER", nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BucketLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    IsTried = table.Column<bool>(type: "INTEGER", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BucketLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BucketLists_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BucketLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false),
                    Stars = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "BgColor", "Country", "CountryFlag", "Emoji", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "#1a3a5c", "Turkey", "🇹🇷", "🕌", "/images/cities/istanbul.jpg", "Istanbul" },
                    { 2, "#1a1a2e", "Japan", "🇯🇵", "⛩️", "/images/cities/tokyo.jpg", "Tokyo" },
                    { 3, "#006994", "Italy", "🇮🇹", "🏛️", "/images/cities/napoli.jpg", "Naples" },
                    { 4, "#1a4a2e", "Thailand", "🇹🇭", "🛺", "/images/cities/bangkok.jpg", "Bangkok" },
                    { 5, "#3a1a0a", "Mexico", "🇲🇽", "🌵", "/images/cities/mexico-city.jpg", "Mexico City" },
                    { 6, "#1a1a4a", "France", "🇫🇷", "🗼", "/images/cities/paris.jpg", "Paris" },
                    { 7, "#8B0000", "Spain", "🇪🇸", "🐂", "/images/cities/madrid.jpg", "Madrid" },
                    { 8, "#c0392b", "Spain", "🇪🇸", "🏖️", "/images/cities/barcelona.jpg", "Barcelona" },
                    { 9, "#2c3e50", "USA", "🇺🇸", "🗽", "/images/cities/new-york.jpg", "New York" },
                    { 10, "#b5770d", "UAE", "🇦🇪", "🏙️", "/images/cities/dubai.jpg", "Dubai" },
                    { 11, "#c0392b", "Singapore", "🇸🇬", "🦁", "/images/cities/singapore.jpg", "Singapore" },
                    { 12, "#2d3436", "Germany", "🇩🇪", "🐻", "/images/cities/berlin.jpg", "Berlin" },
                    { 13, "#6c3483", "India", "🇮🇳", "🕍", "/images/cities/mumbai.jpg", "Mumbai" },
                    { 14, "#1e8449", "Peru", "🇵🇪", "🦙", "/images/cities/lima.jpg", "Lima" },
                    { 15, "#784212", "Morocco", "🇲🇦", "🏜️", "/images/cities/marakes.jpg", "Marrakech" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Category", "CityId", "Description", "Emoji", "ImageUrl", "IsSpicy", "IsVegetarian", "Name", "PriceRange", "Rating", "ReviewCount" },
                values: new object[,]
                {
                    { 1, "Street Food", 1, "Istanbul's legendary street food. Fresh grilled fish served with salad and lemon at the Galata Bridge.", "🥙", "/images/foods/balik-ekmek.jpg", false, false, "Balik Ekmek", "₺", 4.5999999999999996, 512 },
                    { 2, "Dessert", 1, "A legendary dessert from Antep. Thin kadaif pastry filled with fresh cheese and soaked in sweet syrup, served hot.", "🍮", "/images/foods/kunefe.jpg", false, false, "Kunefe", "₺₺", 4.7000000000000002, 452 },
                    { 3, "Meat Dish", 1, "The famous kebab of Bursa. Döner meat served with melted butter, tomato sauce, and yogurt.", "🥗", "/images/foods/iskender.jpg", false, false, "Iskender Kebab", "₺₺", 4.7999999999999998, 634 },
                    { 4, "Street Food", 1, "An Istanbul street staple. Mussels stuffed with spiced rice, squeezed with lemon before eating.", "🦪", "/images/foods/midye.jpg", false, false, "Stuffed Mussels", "₺", 4.4000000000000004, 389 },
                    { 5, "Street Food", 1, "The iconic Turkish bagel. Crispy, sesame-coated ring-shaped bread fresh from the oven.", "🥯", "/images/foods/simit.jpg", false, true, "Simit", "₺", 4.5, 720 },
                    { 6, "Soup", 2, "The soul of Tokyo. Rich pork bone broth simmered for hours, served with thin noodles, egg, and char siu.", "🍜", "/images/foods/ramen.jpg", false, false, "Tonkotsu Ramen", "€€€", 4.7000000000000002, 781 },
                    { 7, "Seafood", 2, "A chef's selection of fresh fish and rice combinations. Tokyo's most prestigious dining experience.", "🍣", "/images/foods/sushi.jpg", false, false, "Sushi Omakase", "€€€€", 4.9000000000000004, 345 },
                    { 8, "Grilled", 2, "Charcoal-grilled chicken skewers. Served with tare sauce or salt, pairs perfectly with a cold beer.", "🍢", "/images/foods/yakitori.jpg", false, false, "Yakitori", "€€", 4.5, 456 },
                    { 9, "Street Food", 2, "Small balls filled with octopus pieces. Served with okonomiyaki sauce, mayo, and bonito flakes.", "🐙", "/images/foods/takoyaki.jpg", false, false, "Takoyaki", "€", 4.5999999999999996, 523 },
                    { 10, "Pizza", 3, "The original Neapolitan pizza. Baked in a wood-fired oven in 90 seconds, with San Marzano tomatoes and buffalo mozzarella.", "🍕", "/images/foods/pizza.jpg", false, true, "Pizza Napoletana", "€€", 4.7999999999999998, 943 },
                    { 11, "Bakery", 3, "Naples' iconic shell-shaped pastry. Crispy dough filled with ricotta and orange zest.", "🥐", "/images/foods/sfogliatella.jpg", false, true, "Sfogliatella", "€", 4.5999999999999996, 312 },
                    { 12, "Pasta", 3, "Naples' seafood pasta made with fresh clams, garlic, white wine, and parsley.", "🍝", "/images/foods/vongole.jpg", false, false, "Spaghetti alle Vongole", "€€€", 4.7000000000000002, 428 },
                    { 13, "Noodles", 4, "Thailand's national dish. Rice noodles stir-fried with shrimp, egg, peanuts, and tamarind sauce.", "🍝", "/images/foods/pad-thai.jpg", true, false, "Pad Thai", "€€", 4.5999999999999996, 385 },
                    { 14, "Soup", 4, "Thailand's sour and spicy soup. Made with shrimp, lemongrass, galangal, kaffir lime leaves, and chili.", "🍲", "/images/foods/tom-yum.jpg", true, false, "Tom Yum Soup", "€€", 4.7000000000000002, 467 },
                    { 15, "Dessert", 4, "Thailand's most beloved dessert. Sweet sticky rice topped with fresh mango slices and coconut milk.", "🥭", "/images/foods/mango-rice.jpg", false, true, "Mango Sticky Rice", "€", 4.7999999999999998, 534 },
                    { 16, "Street Food", 5, "Mexico City's most iconic street food. Marinated pork cooked on a vertical spit, served with pineapple and cilantro.", "🌮", "/images/foods/tacos.jpg", false, false, "Tacos al Pastor", "€", 4.5, 623 },
                    { 17, "Appetizer", 5, "Mexico's essential sauce made with fresh avocado, tomato, onion, cilantro, and lime.", "🥑", "/images/foods/guacamole.jpg", false, true, "Guacamole", "€", 4.5999999999999996, 412 },
                    { 18, "Meat Dish", 5, "Mexico's national dish. Stuffed peppers served with walnut sauce and pomegranate seeds — a colorful feast.", "🫑", "/images/foods/chiles.jpg", false, false, "Chiles en Nogada", "€€€", 4.7000000000000002, 289 },
                    { 19, "Bakery", 6, "Paris' morning ritual. A classic French pastry made with buttery, flaky, golden-layered dough.", "🥐", "/images/foods/croissant.jpg", false, true, "Croissant", "€", 4.7000000000000002, 892 },
                    { 20, "Meat Dish", 6, "The crown of French cuisine. Beef slow-cooked in Burgundy wine with mushrooms and root vegetables.", "🥩", "/images/foods/boeuf.jpg", false, false, "Boeuf Bourguignon", "€€€€", 4.7999999999999998, 334 },
                    { 21, "Dessert", 6, "An icon of French cuisine. Velvety vanilla custard topped with a caramelized sugar crust.", "🍮", "/images/foods/creme-brulee.jpg", false, true, "Crème Brûlée", "€€", 4.7999999999999998, 567 },
                    { 22, "Rice Dish", 7, "Spain's national dish from Valencia. A colorful feast of saffron, seafood, and rice.", "🥘", "/images/foods/paella.jpg", false, false, "Paella", "€€€", 4.7000000000000002, 612 },
                    { 23, "Charcuterie", 7, "Spain's pride. Premium ham from acorn-fed black pigs, aged for years to perfection.", "🥓", "/images/foods/jamon.jpg", false, false, "Jamón Ibérico", "€€€€", 4.9000000000000004, 445 },
                    { 24, "Dessert", 7, "Madrid's morning treat. Fried dough sticks served with thick hot chocolate.", "🍩", "/images/foods/churros.jpg", false, true, "Churros con Chocolate", "€", 4.5999999999999996, 723 },
                    { 25, "Appetizer", 8, "Catalonia's simplest and most delicious dish. Bread rubbed with tomato, garlic, and olive oil — simplicity at its finest.", "🍅", "/images/foods/pan-tomate.jpg", false, true, "Pan con Tomate", "€", 4.5, 398 },
                    { 26, "Dessert", 8, "The ancestor of crème brûlée. Catalan custard flavored with cinnamon and lemon zest.", "🍮", "/images/foods/crema-catalana.jpg", false, true, "Crema Catalana", "€€", 4.7000000000000002, 312 },
                    { 27, "Pizza", 9, "New York's iconic large pizza slice. Thin crust, rich sauce, mozzarella — folding it is mandatory!", "🍕", "/images/foods/ny-pizza.jpg", false, false, "NY Pizza Slice", "€", 4.5999999999999996, 1205 },
                    { 28, "Dessert", 9, "New York-style cheesecake. A legendary dessert made with cream cheese, eggs, and sugar on a graham cracker crust.", "🎂", "/images/foods/cheesecake.jpg", false, true, "Cheesecake", "€€", 4.7999999999999998, 876 },
                    { 29, "Breakfast", 9, "A New York icon. Sesame bagel loaded with cream cheese, smoked salmon, capers, and onion.", "🥯", "/images/foods/bagel.jpg", false, false, "Bagel with Lox", "€€", 4.7000000000000002, 534 },
                    { 30, "Meat Dish", 10, "Dubai's traditional dish. Wheat and meat slow-cooked and mashed together — a Ramadan staple.", "🍲", "/images/foods/harees.jpg", false, false, "Al Harees", "€€", 4.5, 234 },
                    { 31, "Street Food", 10, "The Middle Eastern flavor found on every corner of Dubai. Spiced meat with hummus, pickles, and hot sauce in flatbread.", "🌯", "/images/foods/shawarma.jpg", true, false, "Shawarma", "€", 4.5999999999999996, 892 },
                    { 32, "Chicken", 11, "Singapore's national dish. Tender poached chicken served with aromatic rice, ginger sauce, and chili.", "🍚", "/images/foods/chicken-rice.jpg", false, false, "Hainanese Chicken Rice", "€", 4.7999999999999998, 678 },
                    { 33, "Seafood", 11, "Singapore's pride. Massive crab cooked in a tomato-chili sauce, served with mantou bread.", "🦀", "/images/foods/chilli-crab.jpg", true, false, "Chilli Crab", "€€€€", 4.9000000000000004, 445 },
                    { 34, "Street Food", 12, "Berlin's symbol. Grilled or fried sausage served with curry sauce and curry powder — an iconic street food.", "🌭", "/images/foods/currywurst.jpg", false, false, "Currywurst", "€", 4.5, 789 },
                    { 35, "Street Food", 12, "Berlin's heritage from Turkish immigrants. Lavash bread filled with fresh vegetables, yogurt, and spiced meat.", "🥙", "/images/foods/berliner-doner.jpg", false, false, "Berliner Döner", "€", 4.7000000000000002, 934 },
                    { 36, "Chicken", 13, "India's world-famous dish. Tender chicken floating in a creamy tomato-butter sauce. Perfect with naan bread.", "🍛", "/images/foods/butter-chicken.jpg", true, false, "Butter Chicken", "€€", 4.7999999999999998, 823 },
                    { 37, "Street Food", 13, "Mumbai's burger. A spiced potato fritter in a pav bun, served with chutney — the city's favorite street snack.", "🍔", "/images/foods/vada-pav.jpg", true, true, "Vada Pav", "₺", 4.5999999999999996, 567 },
                    { 38, "Seafood", 14, "Peru's pride. Fresh seafood marinated in lime juice, ají amarillo, and red onion — the world's most refreshing dish.", "🐟", "/images/foods/ceviche.jpg", false, false, "Ceviche", "€€€", 4.9000000000000004, 567 },
                    { 39, "Meat Dish", 14, "A Peruvian-Chinese fusion. Beef stir-fried with tomatoes, garlic, soy sauce, and french fries.", "🥩", "/images/foods/lomo-saltado.jpg", false, false, "Lomo Saltado", "€€€", 4.7000000000000002, 389 },
                    { 40, "Meat Dish", 15, "Morocco's symbol. Lamb slow-cooked with spices and dried fruits in a conical clay pot.", "🫕", "/images/foods/tagine.jpg", false, false, "Tagine", "€€", 4.7999999999999998, 478 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AuthorName", "Comment", "CreatedAt", "FoodId", "Stars" },
                values: new object[,]
                {
                    { 1, "Ahmet Y.", "A must-eat in Istanbul! Having it at the Galata Bridge is a unique experience.", new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 2, "Sara K.", "Very delicious but it can get crowded in the evenings.", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 3, "Mert A.", "Find this ramen in Tokyo, you won't regret it!", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5 },
                    { 4, "Elif D.", "Real Neapolitan pizza tastes completely different. Nothing compares!", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5 },
                    { 5, "Can B.", "Had ceviche in Lima — the best seafood experience of my life!", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 5 },
                    { 6, "Zeynep M.", "Eating tagine in the streets of Marrakech is a one-of-a-kind experience.", new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BucketLists_FoodId",
                table: "BucketLists",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_BucketLists_UserId",
                table: "BucketLists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CityId",
                table: "Foods",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FoodId",
                table: "Reviews",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BucketLists");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
