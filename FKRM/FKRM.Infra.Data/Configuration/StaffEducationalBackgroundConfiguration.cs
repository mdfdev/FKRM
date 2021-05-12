using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    public class StaffEducationalBackgroundConfiguration : IEntityTypeConfiguration<StaffEducationalBackground>
    {
        public void Configure(EntityTypeBuilder<StaffEducationalBackground> builder)
        {
            builder
             .HasKey(b => b.Id);

            builder
               .Property(b => b.Id)
               .ValueGeneratedOnAdd();

            builder
               .HasOne(s => s.AcademicDegree)
               .WithMany(g => g.staffEducationalBackgrounds)
               .HasForeignKey(s => s.AcademicDegreeId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(s => s.AcademicMajor)
               .WithMany(g => g.staffEducationalBackgrounds)
               .HasForeignKey(s => s.AcademicMajorId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
              .HasOne(s => s.Staff)
              .WithMany(g => g.StaffEducationalBackgrounds)
              .HasForeignKey(s => s.StaffId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
