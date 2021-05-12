using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IAcademicDegreeService
    {
        AcademicDegreeViewModel GetById(Guid id);
        Task<Response<int>> Register(AcademicDegreeViewModel academicDegreeViewModel);
        IEnumerable<AcademicDegreeViewModel> GetAll();
        IEnumerable<AcademicDegreeViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(AcademicDegreeViewModel academicDegreeViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
