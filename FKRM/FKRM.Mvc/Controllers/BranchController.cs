using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class BranchController : BaseController<BranchController>
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService, IToastNotification toastNotification):base(toastNotification)
        {
            _branchService = branchService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _branchService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var branchViewModel = new BranchViewModel();
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", branchViewModel) });
            }
            else
            {
                var branchViewModel = _branchService.GetById(id);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", branchViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, BranchViewModel branchViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response= _branchService.Register(branchViewModel);
                        if (response.Result.Data==400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{branchViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response =  _branchService.Update(branchViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{branchViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _branchService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", branchViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _branchService.GetById(id).Name;
                var response=_branchService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _branchService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
