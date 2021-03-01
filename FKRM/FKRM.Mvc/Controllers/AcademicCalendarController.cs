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
    public class AcademicCalendarController : BaseController<AcademicCalendarController>
    {
        private readonly IAcademicCalendarService _academicCalendarService;

        public AcademicCalendarController(IAcademicCalendarService academicCalendarService, IToastNotification toastNotification) : base(toastNotification)
        {
            _academicCalendarService = academicCalendarService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _academicCalendarService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var academicCalendarViewModel = new AcademicCalendarViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicCalendarViewModel) });
            }
            else
            {
                var academicCalendarViewModel = _academicCalendarService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicCalendarViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, AcademicCalendarViewModel academicCalendarViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _academicCalendarService.Register(academicCalendarViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{academicCalendarViewModel.AcademicYear} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _academicCalendarService.Update(academicCalendarViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{academicCalendarViewModel.AcademicYear} {academicCalendarViewModel.AcademicQuarter} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicCalendarService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicCalendarViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var tmp = _academicCalendarService.GetById(id);
                var name = $"{tmp.AcademicYear} {tmp.AcademicQuarter}";
                var response = _academicCalendarService.Remove(id);
                if (response.Result.Data == 400)
                {
                    NotifyErrors(response.Result.Message);
                }
                else
                {
                    NotifyInfo($"{name} حذف شد.");
                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد.");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicCalendarService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
