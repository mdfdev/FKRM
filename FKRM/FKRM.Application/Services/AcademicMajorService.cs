using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Commands.AcademicMajor;
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
    public class AcademicMajorService:IAcademicMajorService
    {
        private readonly IAcademicMajorRepository _academicMajorRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public AcademicMajorService(IAcademicMajorRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _academicMajorRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<AcademicMajorViewModel> GetAll()
        {
            return _academicMajorRepository.GetAll().ProjectTo<AcademicMajorViewModel>(_autoMapper.ConfigurationProvider);

        }

        public AcademicMajorViewModel GetById(Guid id)
        {
            return _autoMapper.Map<AcademicMajorViewModel>(_academicMajorRepository.GetById(id));
        }

        public Task<Response<int>> Register(AcademicMajorViewModel areaViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateAcademicMajorCommand>(areaViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteAcademicMajorCommand(id));
        }

        public Task<Response<int>> Update(AcademicMajorViewModel areaViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateAcademicMajorCommand>(areaViewModel));
        }

        public IEnumerable<AcademicMajorViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _academicMajorRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<AcademicMajorViewModel>(_autoMapper.ConfigurationProvider);
        }

       
    }
}
