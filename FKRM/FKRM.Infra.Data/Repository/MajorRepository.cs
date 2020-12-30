using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Add(Major major)
        {
            _ctx.Add(major);
            _ctx.SaveChanges();
        }

        public IQueryable<Major> GetMajors()
        {
            return _ctx.Majors;
        }
    }
}
