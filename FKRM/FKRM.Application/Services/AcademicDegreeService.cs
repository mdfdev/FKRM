using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Commands.AcademicDegree;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class AcademicDegreeService:IAcademicDegreeService
    {
        private readonly IAcademicDegreeRepository _academicDegreeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public AcademicDegreeService(IAcademicDegreeRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _academicDegreeRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<AcademicDegreeViewModel> GetAll()
        {
            return _academicDegreeRepository.GetAll().ProjectTo<AcademicDegreeViewModel>(_autoMapper.ConfigurationProvider);

        }

        public AcademicDegreeViewModel GetById(Guid id)
        {
            return _autoMapper.Map<AcademicDegreeViewModel>(_academicDegreeRepository.GetById(id));
        }

        public Task<Response<int>> Register(AcademicDegreeViewModel areaViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateAcademicDegreeCommand>(areaViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteAcademicDegreeCommand(id));
        }

        public Task<Response<int>> Update(AcademicDegreeViewModel areaViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateAcademicDegreeCommand>(areaViewModel));
        }

        public IEnumerable<AcademicDegreeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _academicDegreeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<AcademicDegreeViewModel>(_autoMapper.ConfigurationProvider);
        }


    }
}
