using HR.ERP.API.Dtos;
using HR.ERP.API.Service.Auth;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HR.ERP.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [SwaggerTag("Authentication and user management endpoints")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("status")]
        [SwaggerOperation(
            Summary = "Check API Status",
            Description = "Verifies that the API is operational",
            OperationId = "Auth.Status",
            Tags = new[] { "Health" }
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "API is working correctly", typeof(string))]
        public IActionResult GetStatus()
        {
            return Ok("API is working");
        }


        [HttpPost("login")]
        [SwaggerOperation(Summary = "login via Email and Password")]
        public async Task<IActionResult> Login ([FromBody]LoginDto loginDto)
        {
            var result = await _authService.Login(loginDto);

            if (result == null)
                return Unauthorized("Invalid credentials");

            return Ok(result);
        }

    }
}
