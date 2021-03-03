using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IMajorService
    {
        MajorViewModel GetById(Guid id);
        Task<Response<int>> Register(MajorViewModel majorViewModel);
        IEnumerable<MajorViewModel> GetAll();
        IEnumerable<MajorViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(MajorViewModel majorViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
