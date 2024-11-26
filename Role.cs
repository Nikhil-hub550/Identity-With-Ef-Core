using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.Model
{
    public class Role : IdentityRole
    {
        public string Disabled { get; set; }
        public int Heirarchy { get; set; }
    }
}
