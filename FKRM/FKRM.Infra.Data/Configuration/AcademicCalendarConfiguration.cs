using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FKRM.Infra.Data.Configuration
{
    class AcademicCalendarConfiguration : IEntityTypeConfiguration<AcademicCalendar>
    {
        public void Configure(EntityTypeBuilder<AcademicCalendar> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(b => b.AcademicYear)
                .IsRequired();

            builder
                .Property(b => b.AcademicQuarter)
                .IsRequired();
        }
    }
}
