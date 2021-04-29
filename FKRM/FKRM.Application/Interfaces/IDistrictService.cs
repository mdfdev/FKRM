using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IDistrictService
    {
        DistrictViewModel GetById(Guid id);
        Task<Response<int>> Register(DistrictViewModel districtViewModel);
        IEnumerable<DistrictViewModel> GetAll();
        IEnumerable<DistrictViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(DistrictViewModel districtViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
