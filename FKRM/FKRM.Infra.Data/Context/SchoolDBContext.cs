using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FKRM.Domain.Entities;
using FKRM.Infra.Data.Configuration;

namespace FKRM.Infra.Data.Context
{
    public class SchoolDBContext:DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<OUType> OUTypes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public  SchoolDBContext(DbContextOptions options):base(options)
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GenderConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeatureConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UnitTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OUTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolConfiguration).Assembly);
        }
        #endregion
    }
}
