using Microsoft.EntityFrameworkCore;
using StudentProject.DataAccess.Model;

namespace StudentProject.DataAccess.Metadata
{
    public class StudentMetadata
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Student>(entity =>
            {
                entity.ToTable(name: "Students", schema: "master");
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.RollNo).IsRequired();
            });
        }
    }
}
