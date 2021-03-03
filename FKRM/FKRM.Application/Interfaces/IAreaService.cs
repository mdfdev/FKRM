using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IAreaService
    {
        AreaViewModel GetById(Guid id);
        Task<Response<int>> Register(AreaViewModel areaViewModel);
        IEnumerable<AreaViewModel> GetAll();
        IEnumerable<AreaViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(AreaViewModel areaViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
