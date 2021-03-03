using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.OUType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class OUTypeService : IOUTypeService
    {
        private readonly IOUTypeRepository _oUTypeRepository;
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

        public Task<Response<int>> Register(OUTypeViewModel oUTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateOUTypeCommand>(oUTypeViewModel));
        }

        public IEnumerable<OUTypeViewModel> GetAll()
        {
            return _oUTypeRepository.GetAll().ProjectTo<OUTypeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Update(OUTypeViewModel oUTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateOUTypeCommand>(oUTypeViewModel));

        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteOUTypeCommand(id));
        }

        public IEnumerable<OUTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _oUTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<OUTypeViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
