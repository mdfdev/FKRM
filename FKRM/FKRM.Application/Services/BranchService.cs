using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Branch;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public BranchService(IBranchRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _branchRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<BranchViewModel> GetAll()
        {
            return _branchRepository.GetAll().ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }
        public BranchViewModel GetById(Guid id)
        {
            return _autoMapper.Map<BranchViewModel>(_branchRepository.GetById(id));
        }
        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteBranchCommand(id));
        }
        public Task<Response<int>> Update(BranchViewModel branchViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateBranchCommand>(branchViewModel));
        }

        public IEnumerable<BranchViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _branchRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Register(BranchViewModel branchViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateBranchCommand>(branchViewModel));

        }
    }
}
