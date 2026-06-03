namespace TasteTheWorld.Models;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Country { get; set; } = "";
    public string CountryFlag { get; set; } = "";
    public string Emoji { get; set; } = "🏙️";
    public string BgColor { get; set; } = "#1a3a5c";
    public string ImageUrl { get; set; } = "";
    public ICollection<Food> Foods { get; set; } = new List<Food>();
}
