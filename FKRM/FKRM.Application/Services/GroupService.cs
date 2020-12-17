using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GroupService : IGroupService
    {
        private IGroupRepository _groupRepository;
        public GroupService(IGroupRepository repository)
        {
            _groupRepository = repository;
        }
        public GroupViewModel GetGroups()
        {
            return new GroupViewModel()
            {
                groups = _groupRepository.GetGroups()
            };
        }
    }
}
