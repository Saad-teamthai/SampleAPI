using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
namespace AngularAndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            var text = JsonSerializer.Serialize("Hello World");
            return Ok(text);
        }

        [HttpGet]   
        public IActionResult LoginDetails()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return BadRequest();
        }
    }
}
