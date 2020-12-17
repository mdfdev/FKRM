using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Enrollment> GetEnrollments()
        {
            return _ctx.Enrollments;
        }
    }
}
