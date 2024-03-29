// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace YourNamespace.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()
    {
        return "Hello World from HelloController!";
    }
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Projects")] // We will go over this in more detail on the next page
    public string Projects()
    {
        return "These are my projects!";
    }
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Contact")] // We will go over this in more detail on the next page
    public string Contact()
    {
        return "this is my Contact!";
    }


}
