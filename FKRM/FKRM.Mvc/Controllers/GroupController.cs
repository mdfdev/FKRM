using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class GroupController : BaseController<GroupController>
    {
        private readonly IGroupService _groupService;
        private readonly IBranchService _branchService;
        public GroupController(IGroupService groupService ,IBranchService branchService, IToastNotification toastNotification) : base(toastNotification)
        {
            _groupService = groupService;
            _branchService = branchService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _groupService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetGroupList(Guid AreaId)
        {
            var GroupList = _groupService.GetByAreaId(AreaId);
            return Json(GroupList);
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var groupViewModel = new GroupViewModel();
                var branchViewModels = _branchService.GetAll();
                groupViewModel.Branches = new SelectList(branchViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", groupViewModel) });
            }
            else
            {
                var groupViewModel = _groupService.GetById(id);
                var branchViewModels = _branchService.GetAll();
                groupViewModel.Branches = new SelectList(branchViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", groupViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, GroupViewModel groupViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _groupService.Register(groupViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{groupViewModel.Name} ثبت شد");

                        }
                    }
                    else
                    {
                        var response = _groupService.Update(groupViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{groupViewModel.Name} ویرایش شد");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد:{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _groupService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", groupViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _groupService.GetById(id).Name;
                var response = _groupService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _groupService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
