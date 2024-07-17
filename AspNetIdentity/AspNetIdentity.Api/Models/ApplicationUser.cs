using Microsoft.AspNetCore.Identity;

namespace AspNetIdentity.Api.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public override string? PhoneNumber { get; set; }

        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }
    }
}
