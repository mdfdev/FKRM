using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.UnitType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class UnitTypeService : IUnitTypeService
    {
        private readonly IUnitTypeRepository _unitTypeRepository;
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

        public Task<Response<int>> Register(UnitTypeViewModel unitTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateUnitTypeCommand>(unitTypeViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteUnitTypeCommand(id));
        }

        public Task<Response<int>> Update(UnitTypeViewModel unitTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateUnitTypeCommand>(unitTypeViewModel));
        }

        public IEnumerable<UnitTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _unitTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<UnitTypeViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
