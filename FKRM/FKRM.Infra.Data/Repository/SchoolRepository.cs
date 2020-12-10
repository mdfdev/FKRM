using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private SchoolDBContext _ctx;
        public SchoolRepository(SchoolDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<School> GetSchools()
        {
            return _ctx.Schools;
        }
    }
}
