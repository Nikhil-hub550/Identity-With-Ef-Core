using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.IdentityConfiguration
{
    public class AccountLockPolicy
    {
        public static void Configue(IdentityOptions options)
        {
            options.Lockout.AllowedForNewUsers = true;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
            options.Lockout.MaxFailedAccessAttempts = 5;
        }
    }
}
