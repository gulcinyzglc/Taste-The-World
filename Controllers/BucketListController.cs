using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Data;
using TasteTheWorld.Models;

namespace TasteTheWorld.Controllers;

public class BucketListController : Controller
{
    private readonly AppDbContext _db;
    public BucketListController(AppDbContext db) { _db = db; }

    public async Task<IActionResult> Index()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null) return RedirectToAction("Login", "Account");

        var list = await _db.BucketLists
            .Include(b => b.Food).ThenInclude(f => f!.City)
            .Where(b => b.UserId == userId)
            .ToListAsync();
        return View(list);
    }

    [HttpPost]
    public async Task<IActionResult> Toggle(int foodId)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null) return RedirectToAction("Login", "Account");

        var existing = await _db.BucketLists.FirstOrDefaultAsync(b => b.FoodId == foodId && b.UserId == userId);
        if (existing == null)
            _db.BucketLists.Add(new BucketList { FoodId = foodId, UserId = userId });
        else
            _db.BucketLists.Remove(existing);

        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> MarkTried(int id)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null) return RedirectToAction("Login", "Account");

        var item = await _db.BucketLists.FirstOrDefaultAsync(b => b.Id == id && b.UserId == userId);
        if (item != null) { item.IsTried = !item.IsTried; await _db.SaveChangesAsync(); }
        return RedirectToAction("Index");
    }
}

