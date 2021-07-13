using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin)]
    public class AcademicMajorController : BaseController<AcademicMajorController>
    {
        private readonly IAcademicMajorService _academicMajorService;
        public AcademicMajorController(IAcademicMajorService academicMajorService, IToastNotification toastNotification) : base(toastNotification)
        {
            _academicMajorService = academicMajorService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _academicMajorService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var academicMajorViewModel = new AcademicMajorViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicMajorViewModel) });
            }
            else
            {
                var academicMajorViewModel = _academicMajorService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicMajorViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, AcademicMajorViewModel academicMajorViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _academicMajorService.Register(academicMajorViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{academicMajorViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _academicMajorService.Update(academicMajorViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{academicMajorViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicMajorService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", academicMajorViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var tmp = _academicMajorService.GetById(id);
                var name = $"{tmp.Name}";
                var response = _academicMajorService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _academicMajorService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
