using MarketJunctionAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketJunctionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthenticationController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = await _authenticationService.AuthenticateUser(request.Username, request.Password);

                if (user == null)
                    return Unauthorized();

                return Ok(new { Message = "Login successful" });
            }
            catch (Exception ex)
            {
                // Log or inspect the exception details
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine(ex.StackTrace);

                // You can also return a more descriptive error message
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
