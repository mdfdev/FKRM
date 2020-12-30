using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private SchoolDBContext _ctx;
        public EnrollmentRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Enrollment enrollment)
        {
            _ctx.Add(enrollment);
            _ctx.SaveChanges();
        }

        public IQueryable<Enrollment> GetEnrollments()
        {
            return _ctx.Enrollments;
        }
    }
}
