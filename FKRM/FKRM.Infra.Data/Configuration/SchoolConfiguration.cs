using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                 .HasOne(b => b.Gender)
                 .WithMany(b => b.Schools);

            builder
                 .HasOne(b => b.Feature)
                 .WithMany(b => b.Schools);

            builder
                 .HasOne(b => b.OUType)
                 .WithMany(b => b.Schools);

            builder
                 .HasOne(b => b.UnitType)
                 .WithMany(b => b.Schools);
        }
    }
}
