using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class SchoolRepository :  ISchoolRepository
    {
        private SchoolDBContext _ctx;
        public SchoolRepository(SchoolDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(School school)
        {
            _ctx.Add(school);
            _ctx.SaveChanges();
        }

        public IQueryable<School> GetSchools()
        {
            return _ctx.Schools;
        }
    }
}
