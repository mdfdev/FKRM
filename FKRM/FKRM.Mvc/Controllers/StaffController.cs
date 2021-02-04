using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class StaffController : BaseController<StaffController>
    {
        private IStaffService _staffService;
        private readonly IToastNotification _toastNotification;
        public StaffController(IStaffService staffService, IToastNotification toastNotification)
        {
            _staffService = staffService;
            _toastNotification = toastNotification;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _staffService.GetAll());
        }
        public IActionResult Index()
        {
            _toastNotification.AddAlertToastMessage("Same for success message");
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default(Guid))
        {
            if (id == Guid.Empty)
            {
                var staffViewModel = new StaffViewModel();
                return new JsonResult(new { isValid = true, html = _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", staffViewModel) });
            }
            else
            {
                var productViewModel = _staffService.GetById(id);
                return new JsonResult(new { isValid = true, html = _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", productViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, StaffViewModel staffViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        _staffService.Register(staffViewModel);
                        _toastNotification.AddSuccessToastMessage($"پرسنل {staffViewModel.FirstName} {staffViewModel.LastName} ثبت شد.");
                    }
                    else
                    {
                        _staffService.Update(staffViewModel);
                        _toastNotification.AddInfoToastMessage($"پرسنل {staffViewModel.FirstName} {staffViewModel.LastName} ویرایش شد.");
                    }
                }
                catch (Exception ex)
                {
                    _toastNotification.AddErrorToastMessage($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await _viewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", staffViewModel);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                _staffService.Remove(id);
                _toastNotification.AddInfoToastMessage($"پرسنل {id} حذف شد.");
            }
            catch (Exception)
            {
                _toastNotification.AddErrorToastMessage("حذف اطلاعات انجام نشد.");
            }
            var html = await _viewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
