using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoodTrackedLib.RequestModels;

namespace MoodTrackedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRequest request) {
            // Call the register method from the AuthServices
            // var result = _authServices.Register(email, password);
            // return Ok(result);
            return Ok("Register method called");
        }
    }
}
