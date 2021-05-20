using FKRM.Domain.Entities;
using FKRM.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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

            modelBuilder.Entity<Branch>().HasData(
                new Branch { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "فنی و حرفه ای"}, 
                new Branch { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کاردانش" },
                new Branch { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "نظری" }
                );


            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "زن" },
                new Gender { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مرد"}
                );

            modelBuilder.Entity<District>().HasData(
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "ناحیه 1" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "ناحیه 2" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "آشتیان" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "تفرش" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "خمین" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "خنداب" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "سربند" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کمیجان" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دلیجان" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "محلات" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "شازند" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "نوبران" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "زرندیه" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "ساوه" },
                new District { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "فراهان" }
               );

            modelBuilder.Entity<MarkingType>().HasData(
               new MarkingType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "یک نمره ای" },
               new MarkingType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دو نمره ای" },
               new MarkingType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "چهار نمره ای" }
               );

            modelBuilder.Entity<Grade>().HasData(
               new Grade { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دهم" },
               new Grade { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "یازدهم" },
               new Grade { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دوازدهم" }
               );

            modelBuilder.Entity<JobTitle>().HasData(
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "هنرآموز" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "استادکار" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "مدیر" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "معاون فنی" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "معاون آموزشی" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "انباردار" },
              new JobTitle { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Title = "سرپرست بخش" }
              );


            modelBuilder.Entity<OUType>().HasData(
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "استعدادهای درخشان" },
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "شاهد" },
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "عادی" },
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "عام المنفعه" },
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "نمونه دولتی" },
                new OUType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "وابسته" }
                );

            modelBuilder.Entity<Feature>().HasData(
               new Feature { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "هیأت امنایی" },
               new Feature { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "شبانه روزی" }
               );

            modelBuilder.Entity<UnitType>().HasData(
             new UnitType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دولتی" },
             new UnitType { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "غیردولتی" }
             );

            modelBuilder.Entity<AcademicDegree>().HasData(
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "زیر دیپلم" },
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دیپلم" },
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کاردانی" },
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کارشناسی" },
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کارشناسی ارشد" },
                new AcademicDegree { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "دکترا" }
            );

            modelBuilder.Entity<AcademicMajor>().HasData(
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی شهرسازی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "علوم كامپیوتر" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی معماری" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "حسابداری" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "زبان و ادبیات فارسی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی نفت" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی شیمی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی صنایع" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی مکانیک" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "بیوتکنولوژی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "زیست‌فناوری" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "نانوشیمی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "کارآفرینی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مدیریت دولتی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مدیریت فناوری اطلاعات" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مدیریت آموزشی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مدیریت بازرگانی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی معماری" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "معماری" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "معماری داخلی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "فناوری نانو" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی برق" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی پزشکی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی فناوری اطلاعات" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی عمران" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی مواد" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "مهندسی متالورژی و مواد" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "عکاسی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "هنرهای تجسمی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "نقاشی" },
             new AcademicMajor { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Name = "ارتباط تصویری" }
             );

            modelBuilder.Entity<AcademicCalendar>().HasData(
               new AcademicCalendar { Id = Guid.NewGuid(), AddedDate = DateTime.Now,  AcademicYear = "99-1400", AcademicQuarter="ضمن سال" },
               new AcademicCalendar { Id = Guid.NewGuid(), AddedDate = DateTime.Now, AcademicYear = "1400-99", AcademicQuarter = "ضمن سال" }
               );
        }
        #endregion
    }
}
