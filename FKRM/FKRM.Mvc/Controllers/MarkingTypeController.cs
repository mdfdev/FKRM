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
    public class MarkingTypeController : BaseController<MarkingTypeController>
    {
        private readonly IMarkingTypeService _markingTypeService;

        public MarkingTypeController(IMarkingTypeService markingTypeService, IToastNotification toastNotification) : base(toastNotification)
        {
            _markingTypeService = markingTypeService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _markingTypeService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var markingTypeViewModel = new MarkingTypeViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", markingTypeViewModel) });
            }
            else
            {
                var markingTypeViewModel = _markingTypeService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", markingTypeViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, MarkingTypeViewModel markingTypeViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _markingTypeService.Register(markingTypeViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{markingTypeViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _markingTypeService.Update(markingTypeViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{markingTypeViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _markingTypeService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", markingTypeViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _markingTypeService.GetById(id).Name;
                var response = _markingTypeService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _markingTypeService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
