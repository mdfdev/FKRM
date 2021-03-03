using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Enrollment;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public EnrollmentService(IEnrollmentRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _enrollmentRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<EnrollmentViewModel> GetAll()
        {
            return _enrollmentRepository.GetAll().ProjectTo<EnrollmentViewModel>(_autoMapper.ConfigurationProvider);
        }

        public EnrollmentViewModel GetById(Guid id)
        {
            return _autoMapper.Map<EnrollmentViewModel>(_enrollmentRepository.GetById(id));
        }

        public Task<Response<int>> Register(EnrollmentViewModel enrollmentViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateEnrollmentCommand>(enrollmentViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteEnrollmentCommand(id));
        }

        public Task<Response<int>> Update(EnrollmentViewModel enrollmentViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateEnrollmentCommand>(enrollmentViewModel));
        }
        public IEnumerable<EnrollmentViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _enrollmentRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<EnrollmentViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
