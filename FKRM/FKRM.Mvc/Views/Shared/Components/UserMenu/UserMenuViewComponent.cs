using Microsoft.AspNetCore.Mvc;

namespace FKRM.Mvc.Views.Shared.Components.UserMenu
{
    public class UserMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
