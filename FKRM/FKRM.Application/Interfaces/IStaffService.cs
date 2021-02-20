using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IStaffService
    {
        StaffViewModel GetById(Guid id);
        void Register(StaffViewModel staffViewModel);
        IEnumerable<StaffViewModel> GetAll();
        IEnumerable<StaffViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(StaffViewModel staffViewModel);
        void Remove(Guid id);
    }
}
