using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IAcademicMajorService
    {
        AcademicMajorViewModel GetById(Guid id);
        Task<Response<int>> Register(AcademicMajorViewModel academicMajorViewModel);
        IEnumerable<AcademicMajorViewModel> GetAll();
        IEnumerable<AcademicMajorViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(AcademicMajorViewModel academicMajorViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
