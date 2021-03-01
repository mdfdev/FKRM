using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Area;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using FKRM.Domain.Queries.Area;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class AreaService : IAreaService
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public AreaService(IAreaRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _areaRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<AreaViewModel> GetAll()
        {
            return _areaRepository.GetAll().ProjectTo<AreaViewModel>(_autoMapper.ConfigurationProvider);
            
        }

        public AreaViewModel GetById(Guid id)
        {
            return _autoMapper.Map<AreaViewModel>(_areaRepository.GetById(id));
            
        }

        public Task<Response<int>> Register(AreaViewModel areaViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateAreaCommand>(areaViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteAreaCommand(id));
        }

        public Task<Response<int>> Update(AreaViewModel areaViewModel)
        {
           return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateAreaCommand>(areaViewModel));
        }

        public IEnumerable<AreaViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _areaRepository.GetPagedReponse(pageNumber,pageSize).ProjectTo<AreaViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
