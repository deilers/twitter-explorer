using Microsoft.AspNetCore.Mvc;

namespace twitter_explorer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world";
        }
    }
}