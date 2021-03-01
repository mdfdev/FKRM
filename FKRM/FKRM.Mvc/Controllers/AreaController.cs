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
    public class AreaController : BaseController<AreaController>
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService, IToastNotification toastNotification) : base(toastNotification)
        {
            _areaService = areaService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _areaService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var areaViewModel = new AreaViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", areaViewModel) });
            }
            else
            {
                var areaViewModel = _areaService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", areaViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, AreaViewModel areaViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _areaService.Register(areaViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{areaViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _areaService.Update(areaViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{areaViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _areaService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", areaViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _areaService.GetById(id).Name;
                var response = _areaService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _areaService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
