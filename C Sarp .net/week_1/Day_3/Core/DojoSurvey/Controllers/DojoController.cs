using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;  
public class DojoController : Controller   
{      
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}