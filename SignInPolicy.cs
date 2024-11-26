using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.IdentityConfiguration
{
    public class SignInPolicy
    {
        public static void Configure(IdentityOptions options)
        {
            options.SignIn.RequireConfirmedPhoneNumber = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedAccount = true;
        }

    }
}
