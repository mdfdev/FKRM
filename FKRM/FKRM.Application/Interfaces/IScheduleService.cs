using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IScheduleService
    {
        ScheduleViewModel GetById(Guid id);
        Task<Response<int>> Register(ScheduleViewModel scheduleViewModel);
        IEnumerable<ScheduleViewModel> GetAll();
        IEnumerable<ScheduleViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(ScheduleViewModel scheduleViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
