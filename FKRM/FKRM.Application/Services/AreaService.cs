using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Area;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class AreaService : IAreaService
    {
        private IAreaRepository _areaRepository;
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

        public void Register(AreaViewModel areaViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateAreaCommand>(areaViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteAreaCommand(id));
        }

        public void Update(AreaViewModel areaViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateAreaCommand>(areaViewModel));
        }
    }
}
