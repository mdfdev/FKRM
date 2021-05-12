﻿using FKRM.Domain.Entities;
using FKRM.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FKRM.Infra.Data.Context
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<AcademicCalendar> AcademicCalendars { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<AcademicMajor> AcademicMajors { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MarkingType> MarkingTypes { get; set; }
        public DbSet<OUType> OUTypes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffEducationalBackground> StaffEducationalBackgrounds { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<WorkedFor> WorkedFors { get; set; }





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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcademicDegreeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcademicMajorConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AreaConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BranchConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DistrictConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EnrollmentConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeatureConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GenderConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GradeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JobTitleConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MajorConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarkingTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OUTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StaffConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StaffEducationalBackgroundConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UnitTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkedForConfiguration).Assembly);
        }
        #endregion
    }
}
