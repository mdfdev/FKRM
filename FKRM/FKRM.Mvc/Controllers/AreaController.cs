using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class AreaController : BaseController<AreaController>
    {
        private readonly IAreaService _areaService;
        private readonly IBranchService _branchService;

        public AreaController(IAreaService areaService,IBranchService branchService, IToastNotification toastNotification) : base(toastNotification)
        {
            _areaService = areaService;
            _branchService = branchService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _areaService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetAreaList(Guid BranchId)
        {
            var AreaList = _areaService.GetByBranchId(BranchId);
            return Json(AreaList);
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var areaViewModel = new AreaViewModel();
                var branchViewModels =_branchService.GetAll();
                areaViewModel.Branches = new SelectList(branchViewModels,"Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", areaViewModel) });
            }
            else
            {
                var areaViewModel = _areaService.GetById(id);
                var branchViewModels = _branchService.GetAll();
                areaViewModel.Branches = new SelectList(branchViewModels, "Id", "Name", null, null);
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
                            NotifySuccess($"{areaViewModel.Name} ثبت شد");

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
                            NotifyInfo($"{areaViewModel.Name} ویرایش شد");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد{ex.Message}");
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
                    NotifyInfo($"{name} حذف شد");
                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _areaService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
