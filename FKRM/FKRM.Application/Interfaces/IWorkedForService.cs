using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IWorkedForService
    {
        WorkedForViewModel GetById(Guid id);
        Task<Response<int>> Register(WorkedForViewModel workedForViewModel);
        IEnumerable<WorkedForViewModel> GetAll();
        IEnumerable<WorkedForViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(WorkedForViewModel workedForViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
