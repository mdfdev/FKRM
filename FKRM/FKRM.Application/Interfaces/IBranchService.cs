using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IBranchService
    {
        BranchViewModel GetById(Guid id);
        void Register(BranchViewModel branchViewModel);
        IEnumerable<BranchViewModel> GetAll();
        IEnumerable<BranchViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(BranchViewModel branchViewModel);
        void Remove(Guid id);
    }
}
