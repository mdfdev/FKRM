using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IUnitTypeService
    {
        UnitTypeViewModel GetById(Guid id);
        Task<Response<int>> Register(UnitTypeViewModel unitTypeViewModel);
        IEnumerable<UnitTypeViewModel> GetAll();
        IEnumerable<UnitTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(UnitTypeViewModel unitTypeViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
