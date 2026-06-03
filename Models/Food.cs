namespace TasteTheWorld.Models;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Emoji { get; set; } = "🍽️";
    public string ImageUrl { get; set; } = "";
    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public string PriceRange { get; set; } = "€€";
    public string Category { get; set; } = "";
    public bool IsSpicy { get; set; }
    public bool IsVegetarian { get; set; }
    public int CityId { get; set; }
    public City? City { get; set; }
    public ICollection<BucketList> BucketLists { get; set; } = new List<BucketList>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
