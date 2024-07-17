using AspNetIdentity.Api.Services;
using AspNetIdentity.Shared.IdentityAuth.Register;
using AspNetIdentity.Shared.IdentityAuth;
using Microsoft.AspNetCore.Mvc;

namespace AspNetIdentity.Api.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private IUserService _userService;
        private IMailService _mailService;
        private IConfiguration _configuration;
        private IEmployeeService _employeeService;

        public EmployeeController(
            IUserService userService,
            IMailService mailService,
            IConfiguration configuration,
            IEmployeeService employeeService)
        {
            _userService = userService;
            _mailService = mailService;
            _configuration = configuration;
            _employeeService = employeeService;
        }

        // /api/auth/registerEmployee
        [HttpPost("RegisterEmployeeUser")]
        public async Task<ActionResult<RegistrationResponse>> RegisterEmployeeUser([FromBody]RegisterEmployeeVM request)
        {
            return Ok(await _employeeService.RegisterEmployeeUser(request));
        }

    }
}
