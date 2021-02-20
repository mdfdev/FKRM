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
        public IEnumerable<UnitTypeViewModel> GetAll()
        {
            return _unitTypeRepository.GetAll().ProjectTo<UnitTypeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public UnitTypeViewModel GetById(Guid id)
        {
            return _autoMapper.Map<UnitTypeViewModel>(_unitTypeRepository.GetById(id));
        }

        public void Register(UnitTypeViewModel unitTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateUnitTypeCommand>(unitTypeViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteUnitTypeCommand(id));
        }

        public void Update(UnitTypeViewModel unitTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateUnitTypeCommand>(unitTypeViewModel));
        }

        public IEnumerable<UnitTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _unitTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<UnitTypeViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
