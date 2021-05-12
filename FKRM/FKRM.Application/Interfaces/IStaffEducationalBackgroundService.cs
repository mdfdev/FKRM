using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IStaffEducationalBackgroundService
    {
        StaffEducationalBackgroundViewModel GetById(Guid id);
        Task<Response<int>> Register(StaffEducationalBackgroundViewModel staffEducationalBackgroundViewModel);
        IEnumerable<StaffEducationalBackgroundViewModel> GetAll();
        IEnumerable<StaffEducationalBackgroundViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(StaffEducationalBackgroundViewModel staffEducationalBackgroundViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
