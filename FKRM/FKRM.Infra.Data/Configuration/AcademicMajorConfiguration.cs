using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    public class AcademicMajorConfiguration : IEntityTypeConfiguration<AcademicMajor>
    {
        public void Configure(EntityTypeBuilder<AcademicMajor> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
               .Property(b => b.Id)
               .ValueGeneratedOnAdd();
        }
    }
}
