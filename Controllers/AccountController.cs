using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteTheWorld.Data;
using TasteTheWorld.Models;

namespace TasteTheWorld.Controllers;

public class AccountController : Controller
{
    private readonly AppDbContext _db;
    public AccountController(AppDbContext db) { _db = db; }

  
    public IActionResult Register() 
    {
        if (HttpContext.Session.GetString("UserEmail") != null)
            return RedirectToAction("Index", "Home");
        return View();
    }

 
    [HttpPost]
    public async Task<IActionResult> Register(string fullName, string email, string password, string confirmPassword)
    {
  
        if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            ViewBag.Error = "Please fill in all fields.";
            return View();
        }

        if (password != confirmPassword)
        {
            ViewBag.Error = "Passwords do not match!";
            return View();
        }

        if (password.Length < 6)
        {
            ViewBag.Error = "Password must be at least 6 characters.";
            return View();
        }

        var existing = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (existing != null)
        {
            ViewBag.Error = "This email address is already registered!";
            return View();
        }

        var user = new User { FullName = fullName, Email = email, Password = password };
        _db.Users.Add(user);
        await _db.SaveChangesAsync();

        HttpContext.Session.SetInt32("UserId", user.Id);
        HttpContext.Session.SetString("UserEmail", user.Email);
        HttpContext.Session.SetString("UserName", user.FullName);

        TempData["Success"] = "Account created! Welcome, " + user.FullName + "! 🎉";
        return RedirectToAction("Index", "Home");
    }


    public IActionResult Login()
    {
        if (HttpContext.Session.GetString("UserEmail") != null)
            return RedirectToAction("Index", "Home");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            ViewBag.Error = "Email and password are required.";
            return View();
        }

        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        if (user == null)
        {
            ViewBag.Error = "Invalid email or password!";
            return View();
        }

        HttpContext.Session.SetInt32("UserId", user.Id);
        HttpContext.Session.SetString("UserEmail", user.Email);
        HttpContext.Session.SetString("UserName", user.FullName);

        TempData["Success"] = "Welcome, " + user.FullName + "! 👋";
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        TempData["Success"] = "Successfully logged out.";
        return RedirectToAction("Index", "Home");
    }
}

