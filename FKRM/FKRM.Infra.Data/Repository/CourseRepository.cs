using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private SchoolDBContext _ctx;
        public CourseRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
