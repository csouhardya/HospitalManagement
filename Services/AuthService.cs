using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HospitalManagement.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Login(LoginRequest request)
        {
            if (request.UserName == "admin" && request.Password == "admin123")
            {
                return GenerateToken("1", "Admin");
            }

            if (request.UserName == "doctor" && request.Password == "doctor123")
            {
                return GenerateToken("2", "Doctor");
            }

            throw new Exception("Invalid login");
        }

        private string GenerateToken(string userId, string role)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Role, role)
        };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
