using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Data;
using TasteTheWorld.Models;

namespace TasteTheWorld.Controllers;

public class FoodController : Controller
{
    private readonly AppDbContext _db;
    public FoodController(AppDbContext db) { _db = db; }

    public async Task<IActionResult> Index(string? category, string? search, bool? spicy, bool? vegetarian, int page = 1)
    {
        int pageSize = 8;
        var query = _db.Foods.Include(f => f.City).AsQueryable();

        if (!string.IsNullOrEmpty(search))
            query = query.Where(f => f.Name.Contains(search) || f.City!.Name.Contains(search));
        if (!string.IsNullOrEmpty(category))
            query = query.Where(f => f.Category == category);
        if (spicy == true)
            query = query.Where(f => f.IsSpicy);
        if (vegetarian == true)
            query = query.Where(f => f.IsVegetarian);

        int totalItems = await query.CountAsync();
        int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var foods = await query
            .OrderByDescending(f => f.Rating)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        ViewBag.Categories = await _db.Foods.Select(f => f.Category).Distinct().ToListAsync();
        ViewBag.Search = search;
        ViewBag.Category = category;
        ViewBag.IsLoggedIn = HttpContext.Session.GetString("UserEmail") != null;
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.Search = search;
        ViewBag.Category = category;
        ViewBag.Spicy = spicy;
        ViewBag.Vegetarian = vegetarian;

        return View(foods);
    }

    public async Task<IActionResult> Details(int id)
    {
        var food = await _db.Foods.Include(f => f.City).Include(f => f.Reviews).FirstOrDefaultAsync(f => f.Id == id);
        if (food == null) return NotFound();
        ViewBag.RelatedFoods = await _db.Foods.Include(f => f.City)
            .Where(f => f.CityId == food.CityId && f.Id != id).Take(3).ToListAsync();
        ViewBag.IsLoggedIn = HttpContext.Session.GetString("UserEmail") != null;
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> AddReview(int foodId, string authorName, int stars, string comment)
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        _db.Reviews.Add(new Review { FoodId = foodId, AuthorName = authorName, Stars = stars, Comment = comment });
        await _db.SaveChangesAsync();
        return RedirectToAction("Details", new { id = foodId });
    }

    public IActionResult Create()
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        ViewBag.Cities = _db.Cities.ToList();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Food food)
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        if (ModelState.IsValid)
        {
            _db.Foods.Add(food);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Food added successfully! 🍽️";
            return RedirectToAction("Index");
        }
        ViewBag.Cities = await _db.Cities.ToListAsync();
        return View(food);
    }

    public async Task<IActionResult> Edit(int id)
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        var food = await _db.Foods.FindAsync(id);
        if (food == null) return NotFound();
        ViewBag.Cities = await _db.Cities.ToListAsync();
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Food food)
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        if (ModelState.IsValid)
        {
            _db.Foods.Update(food);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Food updated successfully!";
            return RedirectToAction("Index");
        }
        ViewBag.Cities = await _db.Cities.ToListAsync();
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        if (HttpContext.Session.GetString("UserEmail") == null)
            return RedirectToAction("Login", "Account");
        var food = await _db.Foods.FindAsync(id);
        if (food != null) { _db.Foods.Remove(food); await _db.SaveChangesAsync(); }
        TempData["Success"] = "Food deleted.";
        return RedirectToAction("Index");
    }
}
