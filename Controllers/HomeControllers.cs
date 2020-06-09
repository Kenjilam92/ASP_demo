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
        public IActionResult Index2(string str)
        {
            if(str!="projects" && str!="contact")
                return RedirectToAction("Index");
            return View($"{str}");
        }

    }
}