using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var token = _auth.Login(request);

            return Ok(new { token });
        }
    }
}
