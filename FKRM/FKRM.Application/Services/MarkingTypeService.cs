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
            throw new NotImplementedException();
        }

        public void Register(MarkingTypeViewModel markingTypeViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MarkingTypeViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MarkingTypeViewModel markingTypeViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
