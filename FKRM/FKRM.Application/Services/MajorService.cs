using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Major;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class MajorService : IMajorService
    {
        private IMajorRepository _majorRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public MajorService(IMajorRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _majorRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public MajorViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(MajorViewModel majorViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MajorViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MajorViewModel majorViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
