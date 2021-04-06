using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class WorkedForConfiguration : IEntityTypeConfiguration<WorkedFor>
    {
        public void Configure(EntityTypeBuilder<WorkedFor> builder)
        {
            builder
             .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(s => s.AcademicCalendar)
                .WithMany(g => g.WorkedFors)
                .HasForeignKey(s => s.AcademicCalendarId);

            builder
               .HasOne(s => s.Staff)
               .WithMany(g => g.WorkedFors)
               .HasForeignKey(s => s.StaffId);

            builder
               .HasOne(s => s.School)
               .WithMany(g => g.WorkedFors)
               .HasForeignKey(s => s.SchoolId);
        }
    }
}
