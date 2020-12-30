using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IEnrollmentService
    {
        IEnumerable<EnrollmentViewModel> GetEnrollments();
        void Create(EnrollmentViewModel enrollmentViewModel);
    }
}
