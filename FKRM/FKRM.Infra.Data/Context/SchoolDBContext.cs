using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FKRM.Domain.Entities;

namespace FKRM.Infra.Data.Context
{
    public class SchoolDBContext:DbContext
    {
        public  SchoolDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<School> schools { get; set; }
        public DbSet<Gender> genders { get; set; }
    }
}
