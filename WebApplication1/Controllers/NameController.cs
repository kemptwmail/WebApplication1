using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Tyler Kemp" });
        }
    }
}
