using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("Hello pretty");
        }

        [HttpGet]
        [Route("/sub")]
        public IActionResult Child()
        {
            return Ok("Yellow submarine");
        }
    }
}
