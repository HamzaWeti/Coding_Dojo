using Microsoft.AspNetCore.Mvc;
namespace Countdown.Controllers;   
public class DojoController : Controller     
{      
    [HttpGet("")]
    public ViewResult Index()        
    {            
        return View();        
    }
    [HttpPost("Results")]
    public IActionResult Process(string name, string location , string fav , string comment)
    {
        ViewBag.name = name;
        ViewBag.location = location;
        ViewBag.fav = fav;
        ViewBag.comment = comment ;

        return View("View");
    }
}