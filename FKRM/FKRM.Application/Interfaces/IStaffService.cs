using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IStaffService
    {
        StaffViewModel GetById(Guid id);
        void Register(StaffViewModel staffViewModel);
        IEnumerable<StaffViewModel> GetAll();
        void Update(StaffViewModel staffViewModel);
        void Remove(Guid id);
    }
}
