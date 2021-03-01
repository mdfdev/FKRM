using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface ISchoolService
    {
        SchoolViewModel GetById(Guid id);
        Task<Response<int>> Register(SchoolViewModel schoolViewModel);
        IEnumerable<SchoolViewModel> GetAll();
        IEnumerable<SchoolViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(SchoolViewModel schoolViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
