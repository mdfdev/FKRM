using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.School;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;
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

        public Task<Response<int>> Register(SchoolViewModel schoolViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateSchoolCommand>(schoolViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteSchoolCommand(id));
        }

        public Task<Response<int>> Update(SchoolViewModel schoolViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateSchoolCommand>(schoolViewModel));
        }

        public IEnumerable<SchoolViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _schoolRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<SchoolViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
