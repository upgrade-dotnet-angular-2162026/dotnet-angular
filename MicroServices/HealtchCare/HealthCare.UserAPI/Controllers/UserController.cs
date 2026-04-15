using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthCare.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetUser")]
        public IActionResult GetAll()
        {
            return Ok(new string[] { "Rohan", "Karan", "Kavay" });
        }
    }
}
