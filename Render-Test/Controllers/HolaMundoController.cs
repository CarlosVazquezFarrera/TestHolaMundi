using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Render_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() { 
            return Ok("Hola mundo");
        }

    }
}
