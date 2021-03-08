using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder
               .HasOne(s => s.Group)
               .WithMany(g => g.Majors)
               .HasForeignKey(s => s.GroupId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
