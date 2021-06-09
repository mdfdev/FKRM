using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AcademicDegreeController :  BaseController<AcademicDegreeController>
    {
        private readonly IAcademicDegreeService _academicDegreeService;
        public AcademicDegreeController(IAcademicDegreeService academicDegreeService, IToastNotification toastNotification) : base(toastNotification)
        {
            _academicDegreeService = academicDegreeService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _academicDegreeService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var academicDegreeViewModel = new AcademicDegreeViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicDegreeViewModel) });
            }
            else
            {
                var academicDegreeViewModel = _academicDegreeService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicDegreeViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, AcademicDegreeViewModel academicDegreeViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _academicDegreeService.Register(academicDegreeViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{academicDegreeViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _academicDegreeService.Update(academicDegreeViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{academicDegreeViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicDegreeService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicDegreeViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var tmp = _academicDegreeService.GetById(id);
                var name = $"{tmp.Name}";
                var response = _academicDegreeService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicDegreeService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
