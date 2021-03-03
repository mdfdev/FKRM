using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IBranchService
    {
        BranchViewModel GetById(Guid id);
        Task<Response<int>> Register(BranchViewModel branchViewModel);
        IEnumerable<BranchViewModel> GetAll();
        IEnumerable<BranchViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(BranchViewModel branchViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
