using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IEnrollmentService
    {
        EnrollmentViewModel GetById(Guid id);
        Task<Response<int>> Register(EnrollmentViewModel enrollmentViewModel);
        IEnumerable<EnrollmentViewModel> GetAll();
        IEnumerable<EnrollmentViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(EnrollmentViewModel enrollmentViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
