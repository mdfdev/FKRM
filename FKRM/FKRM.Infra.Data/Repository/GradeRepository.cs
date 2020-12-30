using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private SchoolDBContext _ctx;
        public GradeRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Grade grade)
        {
            _ctx.Add(grade);
            _ctx.SaveChanges();
        }

        public IQueryable<Grade> GetGrades()
        {
            return _ctx.Grades;
        }
    }
}
