using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Course;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public CourseService(ICourseRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetAll()
        {
            return _courseRepository.GetAll().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }

        public CourseViewModel GetById(Guid id)
        {
            return _autoMapper.Map<CourseViewModel>(_courseRepository.GetById(id));
        }

        public Task<Response<int>> Register(CourseViewModel branchViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(branchViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteCourseCommand(id));
        }

        public Task<Response<int>> Update(CourseViewModel courseViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateCourseCommand>(courseViewModel));
        }
        public IEnumerable<CourseViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _courseRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
