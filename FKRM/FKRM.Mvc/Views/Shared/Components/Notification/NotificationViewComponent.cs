using FKRM.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FKRM.Mvc.Views.Shared.Components.Notification
{
    public class NotificationViewComponent : ViewComponent
    {
        private readonly INotificationService _notificationService;
        public NotificationViewComponent(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(_notificationService.GetLatest());
        }
    }
}
