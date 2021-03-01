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
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService, IToastNotification toastNotification) : base(toastNotification)
        {
            _schoolService = schoolService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _schoolService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var schoolViewModel = new SchoolViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
            }
            else
            {
                var schoolViewModel = _schoolService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
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
                        var response = _schoolService.Register(schoolViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{schoolViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _schoolService.Update(schoolViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{schoolViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _schoolService.GetById(id).Name;
                var response = _schoolService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
