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
            throw new NotImplementedException();
        }

        public void Register(OUTypeViewModel oUTypeViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OUTypeViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OUTypeViewModel oUTypeViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
