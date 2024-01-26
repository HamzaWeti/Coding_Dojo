using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers;
public class FoodController : Controller 
{
    [HttpGet()]
    [Route("")]
    public ViewResult Index()
    {
        return View ("Index");
    }
}