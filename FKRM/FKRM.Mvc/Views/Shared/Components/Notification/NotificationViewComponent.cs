using Microsoft.AspNetCore.Mvc;

namespace FKRM.Mvc.Views.Shared.Components.Notification
{
    public class NotificationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
