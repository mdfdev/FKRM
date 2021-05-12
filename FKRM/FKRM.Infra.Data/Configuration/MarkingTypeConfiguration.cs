﻿using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class MarkingTypeConfiguration : IEntityTypeConfiguration<MarkingType>
    {
        public void Configure(EntityTypeBuilder<MarkingType> builder)
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
