using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Feature;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class FeatureService : IFeatureService
    {
        private IFeatureRepository _featureRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public FeatureService(IFeatureRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _featureRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(FeatureViewModel featureViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateFeatureCommand>(featureViewModel));
        }

        public IEnumerable<FeatureViewModel> GetFeatures()
        {
            return _featureRepository.GetFeatures().ProjectTo<FeatureViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
