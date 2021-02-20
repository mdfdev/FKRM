using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IUnitTypeService
    {
        UnitTypeViewModel GetById(Guid id);
        void Register(UnitTypeViewModel unitTypeViewModel);
        IEnumerable<UnitTypeViewModel> GetAll();
        IEnumerable<UnitTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(UnitTypeViewModel unitTypeViewModel);
        void Remove(Guid id);
    }
}
