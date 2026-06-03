using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Data;

namespace TasteTheWorld.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;
    public HomeController(AppDbContext db) { _db = db; }

    public async Task<IActionResult> Index()
    {
        ViewBag.Cities = await _db.Cities.Include(c => c.Foods).ToListAsync();
        ViewBag.PopularFoods = await _db.Foods
            .Include(f => f.City)
            .OrderByDescending(f => f.Rating)
            .Take(6).ToListAsync();
        ViewBag.TotalFoods = await _db.Foods.CountAsync();
        ViewBag.TotalCities = await _db.Cities.CountAsync();
        return View();
    }

    public IActionResult About() => View();
}
