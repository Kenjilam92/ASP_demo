using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        // public string Index()
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route ("{str}")]
        public string Index(string str)
        {
            return $"This is my {str}";
        }

    }
}