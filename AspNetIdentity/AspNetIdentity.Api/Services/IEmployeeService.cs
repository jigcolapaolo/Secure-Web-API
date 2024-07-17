using AspNetIdentity.Api.Models;
using AspNetIdentity.Shared.IdentityAuth.Register;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace AspNetIdentity.Api.Services
{
    public interface IEmployeeService
    {
        Task<RegistrationResponse> RegisterEmployeeUser(RegisterEmployeeVM request);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployeeService(
            IAuthService authService,
            UserManager<ApplicationUser> userManager
            )
        {
            _authService = authService;
            _userManager = userManager;
        }

        public async Task<RegistrationResponse> RegisterEmployeeUser(RegisterEmployeeVM request)
        {
            var response = new RegistrationResponse();

            try
            {
                request.UserRole = UserRole.Member;

                RegistrationResponse registrationResponse =
                    await _authService.RegisterAsync(request);

            }
            catch (Exception ex)
            {
                response.Token = "$Couldn't get Token";
            }

            return response;
        }
    }
}
