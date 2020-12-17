using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class MajorRepository : IMajorRepository
    {
        private SchoolDBContext _ctx;
        public MajorRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Major> GetMajors()
        {
            return _ctx.Majors;
        }
    }
}
