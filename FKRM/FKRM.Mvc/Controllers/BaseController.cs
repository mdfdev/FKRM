using FKRM.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NToastNotify;
using System.Collections.Generic;

namespace FKRM.Mvc.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        private IViewRenderService _viewRenderInstance;
        private readonly IToastNotification _toastNotification;
        protected IViewRenderService ViewRenderer => _viewRenderInstance ??= HttpContext.RequestServices.GetService<IViewRenderService>();
        public BaseController(IToastNotification toastNotification)
        {
            this._toastNotification = toastNotification;
        }
        protected void NotifyErrors(List<string> messages)
        {
            foreach (var error in messages)
            {
                _toastNotification.AddErrorToastMessage($" {error} .");

            }
        }
        protected void NotifySuccess(string messages)
        {
            _toastNotification.AddSuccessToastMessage($" {messages} .");
        }
        protected void NotifyError(string messages)
        {
            _toastNotification.AddErrorToastMessage($" {messages} .");
        }
        protected void NotifyInfo(string messages)
        {
            _toastNotification.AddInfoToastMessage($" {messages} .");
        }
    }
}
