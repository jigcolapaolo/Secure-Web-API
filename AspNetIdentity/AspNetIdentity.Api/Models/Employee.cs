namespace AspNetIdentity.Api.Models
{
    public class Employee
    {
        public ApplicationUser ApplicationUser { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeLicense { get; set; }
    }
}
