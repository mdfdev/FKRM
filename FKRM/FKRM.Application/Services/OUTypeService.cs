using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.OUType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class OUTypeService : IOUTypeService
    {
        private IOUTypeRepository _oUTypeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public OUTypeService(IOUTypeRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _oUTypeRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(OUTypeViewModel oUTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateOUTypeCommand>(oUTypeViewModel));
        }

        public IEnumerable<OUTypeViewModel> GetOUTypes()
        {
            return _oUTypeRepository.GetOUTypes().ProjectTo<OUTypeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
