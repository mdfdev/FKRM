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

        public OUTypeViewModel GetById(Guid id)
        {
            return _autoMapper.Map<OUTypeViewModel>(_oUTypeRepository.GetById(id));
        }

        public void Register(OUTypeViewModel oUTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateOUTypeCommand>(oUTypeViewModel));
        }

        public IEnumerable<OUTypeViewModel> GetAll()
        {
            return _oUTypeRepository.GetAll().ProjectTo<OUTypeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public void Update(OUTypeViewModel oUTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateOUTypeCommand>(oUTypeViewModel));

        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteOUTypeCommand(id));
        }

        public IEnumerable<OUTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _oUTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<OUTypeViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
