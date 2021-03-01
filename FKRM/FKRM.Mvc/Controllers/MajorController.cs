using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class MajorController : BaseController<MajorController>
    {
        private readonly IMajorService _majorService;

        public MajorController(IMajorService majorService, IToastNotification toastNotification) : base(toastNotification)
        {
            _majorService = majorService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _majorService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var majorViewModel = new MajorViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", majorViewModel) });
            }
            else
            {
                var majorViewModel = _majorService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", majorViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, MajorViewModel majorViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _majorService.Register(majorViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{majorViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _majorService.Update(majorViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{majorViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _majorService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", majorViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _majorService.GetById(id).Name;
                var response = _majorService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _majorService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
