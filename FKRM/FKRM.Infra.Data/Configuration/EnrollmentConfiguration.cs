using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder
              .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.Capacity)
            .IsRequired();


            builder
              .HasOne(s => s.WorkedFor)
              .WithMany(g => g.Enrollments)
              .HasForeignKey(s => s.WorkedForId);

            builder
                .HasOne(s => s.Course)
                .WithMany(g => g.Enrollments)
                .HasForeignKey(s => s.CourseId);
        }
    }
}
