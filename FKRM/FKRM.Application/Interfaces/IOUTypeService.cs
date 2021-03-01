using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IOUTypeService
    {
        OUTypeViewModel GetById(Guid id);
        Task<Response<int>> Register(OUTypeViewModel oUTypeViewModel);
        IEnumerable<OUTypeViewModel> GetAll();
        IEnumerable<OUTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(OUTypeViewModel oUTypeViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
