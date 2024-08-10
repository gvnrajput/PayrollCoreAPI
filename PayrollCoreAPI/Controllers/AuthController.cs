using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Common;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            _logger.LogInformation("Login attempt for user: {Username}", userLogin.Username);

            if (userLogin.Username == "test" && userLogin.Password == "password")
            {
                _logger.LogInformation("User {Username} authenticated successfully", userLogin.Username);

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("A1B2C3D4E5F6G7H8I9J0K1L2M3N4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6");

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", "1") }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                _logger.LogInformation("Token generated for user {Username}: {Token}", userLogin.Username, tokenString);

                return Ok(new { Token = tokenString });
            }

            _logger.LogWarning("Invalid login attempt for user: {Username}", userLogin.Username);
            return Unauthorized();
        }
    }
}
