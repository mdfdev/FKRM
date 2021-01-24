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

        public IEnumerable<GroupViewModel> GetAll()
        {
            return _groupRepository.GetAll().ProjectTo<GroupViewModel>(_autoMapper.ConfigurationProvider);
        }

        public GroupViewModel GetById(Guid id)
        {
            return _autoMapper.Map<GroupViewModel>(_groupRepository.GetById(id));
        }

        public void Register(GroupViewModel groupViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateGroupCommand>(groupViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteGroupCommand(id));
        }

        public void Update(GroupViewModel groupViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateGroupCommand>(groupViewModel));
        }
    }
}
