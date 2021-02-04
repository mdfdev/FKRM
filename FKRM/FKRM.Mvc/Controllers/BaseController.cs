using FKRM.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FKRM.Mvc.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        private IViewRenderService _viewRenderInstance;
        protected IViewRenderService _viewRenderer => _viewRenderInstance ??= HttpContext.RequestServices.GetService<IViewRenderService>();
    }
}
