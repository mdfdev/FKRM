using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IGradeService
    {


        GradeViewModel GetById(Guid id);
        Task<Response<int>> Register(GradeViewModel gradeViewModel);
        IEnumerable<GradeViewModel> GetAll();
        IEnumerable<GradeViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(GradeViewModel gradeViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
