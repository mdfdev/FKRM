using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
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
                .HasOne(s => s.Branch)
                .WithMany(g => g.Areas)
                .HasForeignKey(s => s.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
