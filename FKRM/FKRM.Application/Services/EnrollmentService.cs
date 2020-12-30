using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Enrollment;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private IEnrollmentRepository _enrollmentRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public EnrollmentService(IEnrollmentRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _enrollmentRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(EnrollmentViewModel enrollmentViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateEnrollmentCommand>(enrollmentViewModel));
        }

        public IEnumerable<EnrollmentViewModel> GetEnrollments()
        {
            return _enrollmentRepository.GetEnrollments().ProjectTo<EnrollmentViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
