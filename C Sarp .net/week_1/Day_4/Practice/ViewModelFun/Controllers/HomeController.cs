using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string messg ="hello world!!!";
        return View("Index", messg);
    }

    public IActionResult Privacy()
    {
        int[] num = new int[]{1,12,45,72,82};
        return View(num);
    }
    public IActionResult User()
    {
        string name = "Hamza Oueti";
        return View("User",name);
    }
    public IActionResult Users()
    {
        List<string> nms = new List<string> {"hamza", "yasin", "ahmed"};
        return View("Users", nms);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
