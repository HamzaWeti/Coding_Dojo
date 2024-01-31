
using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;


namespace FormValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("create/user")]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            ViewBag.User= user;
            return View("Privacy");
        }
        return View("Index");
    }
}
