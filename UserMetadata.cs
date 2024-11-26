using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentProject.IdentityProvider.Model;

namespace StudentProject.IdentityProvider.Metadata
{
    public class UserMetadata
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users", schema: "Identity");
                entity.Property(e => e.FullName).HasComputedColumnSql("RTrim([LastName] + ', ' + [MiddleName] + ' ' + [LastName])");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable(name: "Roles", schema: "Identity");
                entity.Property(x => x.Heirarchy);
                entity.Property(x => x.Disabled).HasDefaultValue(true);
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles", schema: "Identity");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaims", schema: "Identity");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims", schema: "Identity");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins", schema: "Identity");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens", schema: "Identity");
            });
        }
    }
}
