using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
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
