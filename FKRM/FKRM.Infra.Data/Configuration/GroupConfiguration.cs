using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
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
                .HasOne(s => s.Area)
                .WithMany(g => g.Groups)
                .HasForeignKey(s => s.AreaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
