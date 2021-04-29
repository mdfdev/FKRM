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
    public class DistrictController : BaseController<DistrictController>
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService, IToastNotification toastNotification) : base(toastNotification)
        {
            _districtService = districtService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _districtService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var districtViewModel = new DistrictViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", districtViewModel) });
            }
            else
            {
                var districtViewModel = _districtService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", districtViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, DistrictViewModel districtViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _districtService.Register(districtViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{districtViewModel.Name} ثبت شد");

                        }
                    }
                    else
                    {
                        var response = _districtService.Update(districtViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{districtViewModel.Name} ویرایش شد");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد:{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _districtService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", districtViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _districtService.GetById(id).Name;
                var response = _districtService.Remove(id);
                if (response.Result.Data == 400)
                {
                    NotifyErrors(response.Result.Message);
                }
                else
                {
                    NotifyInfo($"{name} حذف شد");
                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _districtService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
