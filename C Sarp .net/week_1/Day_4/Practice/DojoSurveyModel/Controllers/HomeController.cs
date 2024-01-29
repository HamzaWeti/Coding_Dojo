using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurveyModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Survey> AllSurvey { get; set; } = new List<Survey>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
[HttpPost]
public IActionResult CreateDojo(Survey newSurvey)
{
    if (newSurvey == null)
    {
        // Handle the case where newSurvey is null
        // For example, return a BadRequest or perform some other action
        return BadRequest("Invalid survey data");
    }
    return View("Privacy",newSurvey);
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
