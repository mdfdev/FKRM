using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository repository)
        {
            _courseRepository = repository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                courses = _courseRepository.GetCourses()
            };
        }
    }
}
