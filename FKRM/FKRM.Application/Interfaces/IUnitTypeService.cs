using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IUnitTypeService
    {
        IEnumerable<UnitTypeViewModel> GetUnitTypes();
        void Create(UnitTypeViewModel unitTypeViewModel);
    }
}
