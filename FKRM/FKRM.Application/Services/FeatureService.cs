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

        public IEnumerable<FeatureViewModel> GetAll()
        {
            return _featureRepository.GetAll().ProjectTo<FeatureViewModel>(_autoMapper.ConfigurationProvider);
        }

        public FeatureViewModel GetById(Guid id)
        {
            return _autoMapper.Map<FeatureViewModel>(_featureRepository.GetById(id));
        }

        public void Register(FeatureViewModel featureViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateFeatureCommand>(featureViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteFeatureCommand(id));
        }

        public void Update(FeatureViewModel featureViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateFeatureCommand>(featureViewModel));
        }

        public IEnumerable<FeatureViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _featureRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<FeatureViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
