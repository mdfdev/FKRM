using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class SchoolController : BaseController<SchoolController>
    {
        private ISchoolService _schoolService;
        private readonly IToastNotification _toastNotification;
        public SchoolController(ISchoolService schoolService, IToastNotification toastNotification)
        {
            _schoolService = schoolService;
            _toastNotification = toastNotification;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _schoolService.GetAll());
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
                var schoolViewModel = new SchoolViewModel();
                return new JsonResult(new { isValid = true, html = _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
            }
            else
            {
                var schoolViewModel = _schoolService.GetById(id);
                return new JsonResult(new { isValid = true, html = _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, SchoolViewModel schoolViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        _schoolService.Register(schoolViewModel);
                        _toastNotification.AddSuccessToastMessage($"پرسنل {schoolViewModel.Name} ثبت شد.");
                    }
                    else
                    {
                        _schoolService.Update(schoolViewModel);
                        _toastNotification.AddInfoToastMessage($"پرسنل {schoolViewModel.Name} ویرایش شد.");
                    }
                }
                catch (Exception ex)
                {
                    _toastNotification.AddErrorToastMessage($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await _viewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _viewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                _schoolService.Remove(id);
                _toastNotification.AddInfoToastMessage($"پرسنل {id} حذف شد.");
            }
            catch (Exception)
            {
                _toastNotification.AddErrorToastMessage("حذف اطلاعات انجام نشد.");
            }
            var html = await _viewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
