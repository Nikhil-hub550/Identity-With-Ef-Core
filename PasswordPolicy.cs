using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.IdentityConfiguration
{
    public class PasswordPolicy
    {
        public static void Configure(IdentityOptions options)
        {
            options.Password.RequireDigit = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = true;
        }
    }
}
