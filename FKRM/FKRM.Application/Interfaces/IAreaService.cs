using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IAreaService
    {
        AreaViewModel GetById(Guid id);
        void Register(AreaViewModel areaViewModel);
        IEnumerable<AreaViewModel> GetAll();
        IEnumerable<AreaViewModel> GetPagedResponse(int pageNumber, int pageSize);
        void Update(AreaViewModel areaViewModel);
        void Remove(Guid id);
    }
}
