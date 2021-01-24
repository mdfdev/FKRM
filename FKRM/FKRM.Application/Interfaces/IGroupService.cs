using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IGroupService
    {
    
        GroupViewModel GetById(Guid id);
        void Register(GroupViewModel groupViewModel);
        IEnumerable<GroupViewModel> GetAll();
        void Update(GroupViewModel groupViewModel);
        void Remove(Guid id);
    }
}
