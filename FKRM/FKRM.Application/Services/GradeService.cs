using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Grade;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeRepository;
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

        public Task<Response<int>> Register(GradeViewModel gradeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateGradeCommand>(gradeViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteGradeCommand(id));
        }

        public Task<Response<int>> Update(GradeViewModel gradeViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateGradeCommand>(gradeViewModel));
        }

        public IEnumerable<GradeViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _gradeRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<GradeViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
