using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
            .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.Name)
            .IsRequired();

            builder
               .HasOne(s => s.Major)
               .WithMany(g => g.Courses)
               .HasForeignKey(s => s.MajorId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasOne(s => s.MarkingType)
              .WithMany(g => g.Courses)
              .HasForeignKey(s => s.MarkingTypeId)
              .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasOne(s => s.Grade)
              .WithMany(g => g.Courses)
              .HasForeignKey(s => s.GradeId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
