using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.JobTitle;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class JobTitleService : IJobTitleService
    {
        private readonly IJobTitleRepository _jobTitleRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public JobTitleService(IJobTitleRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _jobTitleRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public IEnumerable<JobTitleViewModel> GetAll()
        {
            return _jobTitleRepository.GetAll().ProjectTo<JobTitleViewModel>(_autoMapper.ConfigurationProvider);
        }

        public JobTitleViewModel GetById(Guid id)
        {
            return _autoMapper.Map<JobTitleViewModel>(_jobTitleRepository.GetById(id));
        }

        public Task<Response<int>> Register(JobTitleViewModel jobTitleViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateJobTitleCommand>(jobTitleViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteJobTitleCommand(id));
        }

        public Task<Response<int>> Update(JobTitleViewModel jobTitleViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateJobTitleCommand>(jobTitleViewModel));
        }

        public IEnumerable<JobTitleViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _jobTitleRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<JobTitleViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
