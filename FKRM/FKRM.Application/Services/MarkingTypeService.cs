using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Application.Commands.MarkingType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class MarkingTypeService : IMarkingTypeService
    {
        private readonly IMarkingTypeRepository _markingTypeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public MarkingTypeService(IMarkingTypeRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _markingTypeRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public MarkingTypeViewModel GetById(Guid id)
        {
            return _autoMapper.Map<MarkingTypeViewModel>(_markingTypeRepository.GetById(id));
        }

        public Task<Response<int>> Register(MarkingTypeViewModel markingTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateMarkingTypeCommand>(markingTypeViewModel));
        }

        public IEnumerable<MarkingTypeViewModel> GetAll()
        {
            return _markingTypeRepository.GetAll().ProjectTo<MarkingTypeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Update(MarkingTypeViewModel markingTypeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateMarkingTypeCommand>(markingTypeViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteMarkingTypeCommand(id));
        }
        public IEnumerable<MarkingTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _markingTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<MarkingTypeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
