using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Branch;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _branchRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public BranchService(IBranchRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _branchRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public void Create(BranchViewModel branchViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateBranchCommand>(branchViewModel));
        }

        public IEnumerable<BranchViewModel> GetBranchs()
        {
            return _branchRepository.GetBranches().ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
