using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IFeatureService
    {
        FeatureViewModel GetById(Guid id);
        void Register(FeatureViewModel featureViewModel);
        IEnumerable<FeatureViewModel> GetAll();
        IEnumerable<FeatureViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(FeatureViewModel featureViewModel);
        void Remove(Guid id);
    }
}
