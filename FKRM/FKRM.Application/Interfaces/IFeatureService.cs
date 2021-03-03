using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IFeatureService
    {
        FeatureViewModel GetById(Guid id);
        Task<Response<int>> Register(FeatureViewModel featureViewModel);
        IEnumerable<FeatureViewModel> GetAll();
        IEnumerable<FeatureViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(FeatureViewModel featureViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
