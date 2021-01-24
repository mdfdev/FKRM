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

        public IEnumerable<EnrollmentViewModel> GetAll()
        {
            return _enrollmentRepository.GetAll().ProjectTo<EnrollmentViewModel>(_autoMapper.ConfigurationProvider);
        }

        public EnrollmentViewModel GetById(Guid id)
        {
            return _autoMapper.Map<EnrollmentViewModel>(_enrollmentRepository.GetById(id));
        }

        public void Register(EnrollmentViewModel enrollmentViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateEnrollmentCommand>(enrollmentViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteEnrollmentCommand(id));
        }

        public void Update(EnrollmentViewModel enrollmentViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateEnrollmentCommand>(enrollmentViewModel));
        }
    }
}
