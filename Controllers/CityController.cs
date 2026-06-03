using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Data;

namespace TasteTheWorld.Controllers;

public class CityController : Controller
{
    private readonly AppDbContext _db;
    public CityController(AppDbContext db) { _db = db; }

    public async Task<IActionResult> Index()
    {
        var cities = await _db.Cities.Include(c => c.Foods).ToListAsync();
        return View(cities);
    }

    public async Task<IActionResult> Details(int id)
    {
        var city = await _db.Cities
            .Include(c => c.Foods)
            .FirstOrDefaultAsync(c => c.Id == id);
        if (city == null) return NotFound();
        return View(city);
    }
}
