using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class OUTypeConfiguration : IEntityTypeConfiguration<OUType>
    {
        public void Configure(EntityTypeBuilder<OUType> builder)
        {
            builder
              .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.Name)
            .HasMaxLength(255)
            .IsRequired();
        }
    }
}
