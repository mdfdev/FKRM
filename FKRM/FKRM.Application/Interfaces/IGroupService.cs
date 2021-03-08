using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IGroupService
    {

        GroupViewModel GetById(Guid id);
        Task<Response<int>> Register(GroupViewModel groupViewModel);
        IEnumerable<GroupViewModel> GetAll();
        IEnumerable<GroupViewModel> GetByAreaId(Guid id);

        IEnumerable<GroupViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(GroupViewModel groupViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
