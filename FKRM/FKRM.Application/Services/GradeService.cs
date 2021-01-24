using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Grade;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using FKRM.Domain.Queries.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<GradeViewModel> GetAll()
        {
            return _gradeRepository.GetAll().ProjectTo<GradeViewModel>(_autoMapper.ConfigurationProvider);
        }

        public GradeViewModel GetById(Guid id)
        {
            return _autoMapper.Map<GradeViewModel>(_gradeRepository.GetById(id));
        }

        public void Register(GradeViewModel gradeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateGradeCommand>(gradeViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteGradeCommand(id));
        }

        public void Update(GradeViewModel gradeViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateGradeCommand>(gradeViewModel));
        }
    }
}
