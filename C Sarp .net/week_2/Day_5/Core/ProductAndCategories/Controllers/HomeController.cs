using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAndCategories.Data;
using ProductAndCategories.Models;

namespace ProductAndCategories.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private  AppDbContext _db;
    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    public IActionResult Index()
    {
        ViewBag.AllProducts = _db.Products.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult NewProduct (Product product)
    {
        if (ModelState.IsValid)
        {
            // 1  Add
            _db.Add(product);
            // 2 Save
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Display Error messages
        return View("Index");
    }
    
    














    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
