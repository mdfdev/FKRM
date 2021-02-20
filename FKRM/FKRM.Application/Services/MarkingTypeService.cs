using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.MarkingType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class MarkingTypeService : IMarkingTypeService
    {
        private IMarkingTypeRepository _markingTypeRepository;
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

        public void Register(MarkingTypeViewModel markingTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateMarkingTypeCommand>(markingTypeViewModel));
        }

        public IEnumerable<MarkingTypeViewModel> GetAll()
        {
            return _markingTypeRepository.GetAll().ProjectTo<MarkingTypeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public void Update(MarkingTypeViewModel markingTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateMarkingTypeCommand>(markingTypeViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteMarkingTypeCommand(id));
        }
        public IEnumerable<MarkingTypeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _markingTypeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<MarkingTypeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
