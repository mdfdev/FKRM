using FKRM.Domain.Constants;
using FKRM.Infra.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin));
            await roleManager.CreateAsync(new IdentityRole(Roles.Moderator));
            await roleManager.CreateAsync(new IdentityRole(Roles.Basic));
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "96267157",
                EmployeeId = "96267157",
                Email = "96267157@gmail.com",
                FirstName = "میثم",
                LastName = "فراهانی",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Basic);
                    await userManager.AddToRoleAsync(defaultUser, Roles.Moderator);
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin);
                    await userManager.AddToRoleAsync(defaultUser, Roles.SuperAdmin);
                }

            }
        }
    }
}
