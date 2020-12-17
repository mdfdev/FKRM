using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class FeatureService : IFeatureService
    {
        private IFeatureRepository _featureRepository;
        public FeatureService(IFeatureRepository repository)
        {
            _featureRepository = repository;
        }
        public FeatureViewModel GetFeatures()
        {
            return new FeatureViewModel()
            {
                features = _featureRepository.GetFeatures()
            };
        }
    }
}
