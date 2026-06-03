namespace TasteTheWorld.Models;

public class BucketList
{
    public int Id { get; set; }
    public int FoodId { get; set; }
    public Food? Food { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
    public bool IsTried { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.Now;
}

public class Review
{
    public int Id { get; set; }
    public int FoodId { get; set; }
    public Food? Food { get; set; }
    public string AuthorName { get; set; } = "";
    public int Stars { get; set; }
    public string Comment { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
