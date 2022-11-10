using jwtWebApi.Models;
using jwtWebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace jwtWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("{id}"), Authorize(Roles = "User")]
        public async Task<IActionResult> ProfileAsync([FromRoute] string id)
        {
            var user = await _authService.GetUserProfileAsync(id);
            return Ok(new { FullName = user.FullName, Email = user.Email, Image = user.Image });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(new { errors = result.Message });

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.LoginAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(new { errors = result.Message });

            return Ok(result);
        }
    }
}
