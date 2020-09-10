using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("/simpleapp")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello pretty");
        }

        [HttpGet]
        [Route("sub")]
        public IActionResult Child()
        {
            return Ok("Yellow submarine");
        }
    }
}
