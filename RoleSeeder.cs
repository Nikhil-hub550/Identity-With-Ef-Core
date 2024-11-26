using Microsoft.EntityFrameworkCore;
using StudentProject.IdentityProvider.Enum;
using StudentProject.IdentityProvider.Model;

namespace StudentProject.IdentityProvider.Seeder
{
    public class RoleSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasData(new Role
                {
                    Name = "Administration",
                    NormalizedName = "ADMIN",
                    Heirarchy = (int)Heirarchy.ADMIN
                });
                entity.HasData(new Role
                {
                    Name = "Client",
                    NormalizedName = "CLIENT",
                    Heirarchy = (int)Heirarchy.CLIENT
                });
            });
        }
    }
}
