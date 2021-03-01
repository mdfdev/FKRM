using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IMarkingTypeService
    {
        MarkingTypeViewModel GetById(Guid id);
        Task<Response<int>> Register(MarkingTypeViewModel markingTypeViewModel);
        IEnumerable<MarkingTypeViewModel> GetAll();
        IEnumerable<MarkingTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(MarkingTypeViewModel markingTypeViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
