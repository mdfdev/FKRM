using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace FKRM.Application.Interfaces
{
    public interface INotificationService
    {
        NotificationViewModel GetById(Guid id);
        Task<Response<int>> Register(NotificationViewModel notificationViewModel);
        IEnumerable<NotificationViewModel> GetAll();
        IEnumerable<NotificationViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(NotificationViewModel notificationViewModel);
        Task<Response<int>> Remove(Guid id);
        IEnumerable<NotificationViewModel> GetAllData();
        IEnumerable<NotificationViewModel> GetLatest();
    }
}
