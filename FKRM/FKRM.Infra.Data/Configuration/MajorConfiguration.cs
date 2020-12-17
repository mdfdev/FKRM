using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder
             .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.Name)
            .IsRequired();
        }
    }
}
