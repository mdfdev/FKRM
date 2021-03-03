using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IGenderService
    {
        GenderViewModel GetById(Guid id);
        Task<Response<int>> Register(GenderViewModel genderViewModel);
        IEnumerable<GenderViewModel> GetAll();
        IEnumerable<GenderViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(GenderViewModel genderViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
