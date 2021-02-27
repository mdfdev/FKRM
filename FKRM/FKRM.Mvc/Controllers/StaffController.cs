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
        public StaffController(IStaffService staffService, IToastNotification toastNotification):base(toastNotification)
        {
            _staffService = staffService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _staffService.GetAll());
        }
        public IActionResult Index()
        {
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
                        NotifySuccess($"پرسنل {staffViewModel.FirstName} {staffViewModel.LastName} ثبت شد.");
                    }
                    else
                    {
                        _staffService.Update(staffViewModel);
                        NotifyInfo($"پرسنل {staffViewModel.FirstName} {staffViewModel.LastName} ویرایش شد.");
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
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
                NotifyInfo($"پرسنل {id} حذف شد.");
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد.");
            }
            var html = await _viewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
