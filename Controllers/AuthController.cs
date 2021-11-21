using Microsoft.AspNetCore.Mvc;

namespace UofLMentorshipProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("refresh_token")]
        public async Task<IActionResult> Get()
        {
            
            return Ok();
        }
    }
}