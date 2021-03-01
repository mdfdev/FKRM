using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Feature;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;
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

        public Task<Response<int>> Register(FeatureViewModel featureViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateFeatureCommand>(featureViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteFeatureCommand(id));
        }

        public Task<Response<int>> Update(FeatureViewModel featureViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateFeatureCommand>(featureViewModel));
        }

        public IEnumerable<FeatureViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _featureRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<FeatureViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
