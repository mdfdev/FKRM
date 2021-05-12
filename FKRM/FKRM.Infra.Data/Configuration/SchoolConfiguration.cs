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
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(s => s.Feature)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.FeatureId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(s => s.OUType)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.OUTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(s => s.UnitType)
               .WithMany(g => g.Schools)
               .HasForeignKey(s => s.UnitTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Subsidiary)
                .WithMany()
                .HasForeignKey(x=>x.SubsidiaryId);

            builder
                .HasOne(s => s.Branch)
                .WithMany(g => g.Schools)
                .HasForeignKey(s => s.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
