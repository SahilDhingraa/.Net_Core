using Microsoft.AspNetCore.Mvc;
using udemy1.Data;
using udemy1.Dtos.User;
using udemy1.Services.CharacterService;

namespace udemy1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var responnse = await _authRepo.Register(
                new User { Usernmae = request.Username }, request.password
            );
            if (!responnse.Success)
            {
                return BadRequest(responnse);
            }
            return Ok(responnse);
        }
        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> login(UserLoginDto request)
        {
            var responnse = await _authRepo.Login(request.Username, request.Password);
            if (!responnse.Success)
            {
                return BadRequest(responnse);
            }
            return Ok(responnse);
        }
    }
}