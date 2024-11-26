using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.IdentityConfiguration
{
    public class UserDetailPolicy
    {
        public static void Configure(IdentityOptions options)
        {
            options.User.RequireUniqueEmail = true;
            //Defaults to abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+
            options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+#$%^&*";
        }
    }
}
