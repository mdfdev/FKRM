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
        void Update(UnitTypeViewModel unitTypeViewModel);
        void Remove(Guid id);
    }
}
