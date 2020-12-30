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
        public void Create(SchoolViewModel schoolViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateSchoolCommand>(schoolViewModel));
        }

        public IEnumerable<SchoolViewModel> GetSchools()
        {
            return _schoolRepository.GetSchools().ProjectTo<SchoolViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
