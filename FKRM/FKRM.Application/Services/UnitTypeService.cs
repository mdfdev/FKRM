using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.UnitType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class UnitTypeService : IUnitTypeService
    {
        private IUnitTypeRepository _unitTypeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public UnitTypeService(IUnitTypeRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _unitTypeRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(UnitTypeViewModel unitTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateUnitTypeCommand>(unitTypeViewModel));
        }

        public IEnumerable<UnitTypeViewModel> GetUnitTypes()
        {
            return _unitTypeRepository.GetUnitTypes().ProjectTo<UnitTypeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
