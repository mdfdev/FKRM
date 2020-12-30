using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Group;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GroupService : IGroupService
    {
        private IGroupRepository _groupRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public GroupService(IGroupRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _groupRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(GroupViewModel groupViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateGroupCommand>(groupViewModel));
        }

        public IEnumerable< GroupViewModel> GetGroups()
        {
            return _groupRepository.GetGroups().ProjectTo<GroupViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
