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
        public void Create(MarkingTypeViewModel markingTypeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateMarkingTypeCommand>(markingTypeViewModel));
        }

        public IEnumerable<MarkingTypeViewModel> GetMarkingTypes()
        {
            return _markingTypeRepository.GetMarkingTypes().ProjectTo<MarkingTypeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
