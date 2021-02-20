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

        public IEnumerable<BranchViewModel> GetAll()
        {
            return _branchRepository.GetAll().ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }

        public BranchViewModel GetById(Guid id)
        {
            return _autoMapper.Map<BranchViewModel>(_branchRepository.GetById(id));
        }

        public void Register(BranchViewModel branchViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateBranchCommand>(branchViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteBranchCommand(id));
        }

        public void Update(BranchViewModel branchViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateBranchCommand>(branchViewModel));
        }

        public IEnumerable<BranchViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _branchRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
