using AuthApiExam.Model;
using AuthApiExam.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthApiExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly TokenGenerator _tokenGenerator;

        public AuthController(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> Login(DtoLogin login)
        {
            var token =  await _tokenGenerator.TGeneratorAsync(login);
            return Ok(token);
        }
    }
}
