using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Common;
using BAL.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ISettingsUserRepository _settingsUserRepository;
        EncryptDecryptPassword encryptDecryptPassword = new EncryptDecryptPassword();
        public AuthController(ILogger<AuthController> logger, ISettingsUserRepository settingsUserRepository)
        {
            _logger = logger;
            _settingsUserRepository = settingsUserRepository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            _logger.LogInformation("Login attempt for user: {Username}", userLogin.Username);

            userLogin.Password = encryptDecryptPassword.encrypt(userLogin.Password);
            if (_settingsUserRepository.ValidateUser(userLogin.Username,userLogin.Password))
            {
                _logger.LogInformation("User {Username} authenticated successfully", userLogin.Username);

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(AppConstants.JwtSecretKey);

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
