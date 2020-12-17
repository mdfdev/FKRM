using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _branchRepository;
        public BranchService(IBranchRepository repository)
        {
            _branchRepository = repository;
        }
        public BranchViewModel GetBranchs()
        {
            return new BranchViewModel()
            {
                branches = _branchRepository.GetBranches()
            };
        }
    }
}
