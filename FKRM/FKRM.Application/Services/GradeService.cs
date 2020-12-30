using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Grade;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GradeService : IGradeService
    {
        private IGradeRepository _gradeRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public GradeService(IGradeRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _gradeRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(GradeViewModel gradeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateGradeCommand>(gradeViewModel));
        }

        public IEnumerable<GradeViewModel> GetGrades()
        {
            return _gradeRepository.GetGrades().ProjectTo<GradeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
