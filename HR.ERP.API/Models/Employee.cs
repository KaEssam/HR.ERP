using Microsoft.AspNetCore.Identity;

namespace HR.ERP.API.Models
{

    public class Employee : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        
        public int DepartmentId { get; set; }
        public string Role { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string OnboardingStatus { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        
        public Department Department { get; set; }
    }
}
