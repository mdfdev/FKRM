using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
              .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.DayOfTheWeek)
            .IsRequired();

            builder
                .Property(b => b.StartTime)
                .IsRequired();

            builder
                .Property(b => b.EndTime)
                .IsRequired();
        }
    }
}
