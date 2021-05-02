using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
               .HasOne(s => s.Gender)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.GenderId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(s => s.Feature)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.FeatureId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(s => s.OUType)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.OUTypeId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(s => s.UnitType)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.UnitTypeId)
               .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Subsidiary)
                .WithMany();
        }
    }
}
