using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IOUTypeService
    {
        OUTypeViewModel GetById(Guid id);
        void Register(OUTypeViewModel oUTypeViewModel);
        IEnumerable<OUTypeViewModel> GetAll();
        IEnumerable<OUTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(OUTypeViewModel oUTypeViewModel);
        void Remove(Guid id);
    }
}
