using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Application.Commands.District;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public DistrictService(IDistrictRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _districtRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<DistrictViewModel> GetAll()
        {
            return _districtRepository.GetAll().ProjectTo<DistrictViewModel>(_autoMapper.ConfigurationProvider);
        }

        public DistrictViewModel GetById(Guid id)
        {
            return _autoMapper.Map<DistrictViewModel>(_districtRepository.GetById(id));
        }

        public IEnumerable<DistrictViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _districtRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<DistrictViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Register(DistrictViewModel districtViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateDistrictCommand>(districtViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteDistrictCommand(id));
        }

        public Task<Response<int>> Update(DistrictViewModel districtViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateDistrictCommand>(districtViewModel));
        }
    }
}
