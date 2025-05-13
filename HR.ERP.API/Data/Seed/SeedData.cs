using HR.ERP.API.Models;
using Microsoft.AspNetCore.Identity;

namespace HR.ERP.API.Data.Seed;

public static class SeedData
{
    public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<Employee>>();

        // Seed Roles
        string[] roleNames = { "Admin", "Manager", "Employee", "HR" };
        
        foreach (var roleName in roleNames)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        // Seed Admin User
        var adminUser = await userManager.FindByEmailAsync("admin@hrapp.com");
        
        if (adminUser == null)
        {
            var admin = new Employee
            {
                UserName = "admin@hrapp.com",
                Email = "admin@hrapp.com",
                EmailConfirmed = true,
                FirstName = "System",
                LastName = "Admin",
                Role = "Admin",
                OnboardingStatus = "Completed"
            };

            var result = await userManager.CreateAsync(admin, "Admin@123456");
            
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}