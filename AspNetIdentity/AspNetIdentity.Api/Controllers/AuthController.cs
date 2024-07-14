using AspNetIdentity.Api.Services;
using AspNetIdentity.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace AspNetIdentity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;
        private IMailService _mailService;

        public AuthController(
            IUserService userService,
            IMailService mailService)
        {
            _userService = userService;
            _mailService = mailService;
        }

        // /api/auth/register
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody]RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterUserAsync(model);

                if (result.IsSuccess)
                    return Ok(result); //Status Code: 200

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid"); //Status code: 400
        }

        // /api/auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);

                if (result.IsSuccess)
                {
                    await _mailService.SendEmailAsync("Jinbyos@Gmail.com", "Inicio de Sesión", _mailService.GetNewLoginNotification());

                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
        }
    }
}
