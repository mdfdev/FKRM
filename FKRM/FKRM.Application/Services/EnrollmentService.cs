using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private IEnrollmentRepository _enrollmentRepository;
        public EnrollmentService(IEnrollmentRepository repository)
        {
            _enrollmentRepository = repository;
        }
        public EnrollmentViewModel GetEnrollments()
        {
            return new EnrollmentViewModel()
            {
                enrollments = _enrollmentRepository.GetEnrollments()
            };
        }
    }
}
