using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentProject.DataAccess.Metadata;
using StudentProject.DataAccess.Model;
using StudentProject.IdentityProvider.Metadata;
using StudentProject.IdentityProvider.Model;
using StudentProject.IdentityProvider.Seeder;

namespace StudentProject.DataAccess
{
    /// <summary>
    /// This class define a DbContext
    /// </summary>
    public class StudentDbContext : IdentityDbContext<User, Role, string>
    {
        private readonly IConfiguration _configuration;
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StudentDbContext()
        {

        }
        public StudentDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RoleSeeder.SeedData(modelBuilder);
            StudentMetadata.Configure(modelBuilder);
            UserMetadata.Configure(modelBuilder);
        }
    }
}
