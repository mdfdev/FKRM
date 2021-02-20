using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IEnrollmentService
    {
        EnrollmentViewModel GetById(Guid id);
        void Register(EnrollmentViewModel enrollmentViewModel);
        IEnumerable<EnrollmentViewModel> GetAll();
        IEnumerable<EnrollmentViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(EnrollmentViewModel enrollmentViewModel);
        void Remove(Guid id);
    }
}
