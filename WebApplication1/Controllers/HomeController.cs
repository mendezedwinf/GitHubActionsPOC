using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, World!"});
        }
    }
}
