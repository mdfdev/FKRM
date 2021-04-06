using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.WorkedFor;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class WorkedForService : IWorkedForService
    {
        private readonly IWorkedForRepository _workedForRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public WorkedForService(IWorkedForRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _workedForRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<WorkedForViewModel> GetAll()
        {
            return _workedForRepository.GetAll().ProjectTo<WorkedForViewModel>(_autoMapper.ConfigurationProvider);

        }

        public WorkedForViewModel GetById(Guid id)
        {
            return _autoMapper.Map<WorkedForViewModel>(_workedForRepository.GetById(id));

        }

        public IEnumerable<WorkedForViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _workedForRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<WorkedForViewModel>(_autoMapper.ConfigurationProvider);

        }

        public Task<Response<int>> Register(WorkedForViewModel workedForViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateWorkedForCommand>(workedForViewModel));

        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteWorkedForCommand(id));
        }

        public Task<Response<int>> Update(WorkedForViewModel workedForViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateWorkedForCommand>(workedForViewModel));
        }
    }
}
