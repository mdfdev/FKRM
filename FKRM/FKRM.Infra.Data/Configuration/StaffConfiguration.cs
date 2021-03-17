using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder
             .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
            .Property(b => b.FirstName)
            .IsRequired();

            builder
                .Property(b => b.LastName)
                .IsRequired();

            builder
                .HasOne(s => s.JobTitle)
                .WithMany(g => g.Staffs)
                .HasForeignKey(s => s.JobTitleId);
        }
    }
}
