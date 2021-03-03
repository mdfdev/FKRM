using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Group;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public GroupService(IGroupRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _groupRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<GroupViewModel> GetAll()
        {
            return _groupRepository.GetAll().ProjectTo<GroupViewModel>(_autoMapper.ConfigurationProvider);
        }

        public GroupViewModel GetById(Guid id)
        {
            return _autoMapper.Map<GroupViewModel>(_groupRepository.GetById(id));
        }

        public Task<Response<int>> Register(GroupViewModel groupViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateGroupCommand>(groupViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteGroupCommand(id));
        }

        public Task<Response<int>> Update(GroupViewModel groupViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateGroupCommand>(groupViewModel));
        }
        public IEnumerable<GroupViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _groupRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<GroupViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
