using FKRM.Domain.Entities;
using FKRM.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FKRM.Infra.Data.Context
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<AcademicCalendar> AcademicCalendars { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MarkingType> MarkingTypes { get; set; }
        public DbSet<OUType> OUTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }






        public SchoolDBContext(DbContextOptions options) : base(options)
        {

        }

        #region Required
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcademicCalendarConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AreaConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BranchConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EnrollmentConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeatureConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GenderConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GradeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MajorConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarkingTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OUTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RoomConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ScheduleConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StaffConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UnitTypeConfiguration).Assembly);
        }
        #endregion
    }
}
