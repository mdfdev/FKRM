using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.School;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class SchoolService : ISchoolService
    {
        private ISchoolRepository _schoolRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public SchoolService(ISchoolRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _schoolRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public IEnumerable<SchoolViewModel> GetAll()
        {
            return _schoolRepository.GetAll().ProjectTo<SchoolViewModel>(_autoMapper.ConfigurationProvider);
        }

        public SchoolViewModel GetById(Guid id)
        {
            return _autoMapper.Map<SchoolViewModel>(_schoolRepository.GetById(id));
        }

        public void Register(SchoolViewModel schoolViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateSchoolCommand>(schoolViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteSchoolCommand(id));
        }

        public void Update(SchoolViewModel schoolViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateSchoolCommand>(schoolViewModel));
        }

        public IEnumerable<SchoolViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _schoolRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<SchoolViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
