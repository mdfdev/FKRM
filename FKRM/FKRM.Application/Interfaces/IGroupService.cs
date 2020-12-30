using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IGroupService
    {
        IEnumerable<GroupViewModel> GetGroups();
        void Create(GroupViewModel groupViewModel);
    }
}
