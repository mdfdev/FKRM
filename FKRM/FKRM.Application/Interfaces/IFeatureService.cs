using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IFeatureService
    {
        IEnumerable<FeatureViewModel> GetFeatures();
        void Create(FeatureViewModel  featureViewModel);
    }
}
