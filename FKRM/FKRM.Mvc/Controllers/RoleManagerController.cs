using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class RoleManagerController : BaseController<RoleManagerController>
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleManagerController(RoleManager<IdentityRole> roleManager, IToastNotification toastNotification) : base(toastNotification)
        {
            _roleManager = roleManager;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _roleManager.Roles.ToList());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(string id)
        {
            if (id == null)
            {
                var identityRole = new IdentityRole();
                identityRole.Id = string.Empty;
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", identityRole) });
            }
            else
            {
                var identityRole = _roleManager.Roles.First(p=>p.Id.CompareTo(id)==0);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", identityRole) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(string id, IdentityRole identityRole)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id==null)
                    {

                        var response = _roleManager.CreateAsync(new IdentityRole(identityRole.Name.Trim()));
                        if (!response.Result.Succeeded)
                        {
                            NotifyErrors(new List<string>() { "ثبت اطلاعات انجام نشد" });
                        }
                        else
                        {
                            NotifySuccess($"{identityRole.Name} ثبت شد");

                        }
                    }
                    else
                    {
                        var response = _roleManager.UpdateAsync(identityRole);
                        if (!response.Result.Succeeded)
                        {
                            NotifyErrors(new List<string>() { "ثبت اطلاعات انجام نشد" });
                        }
                        else
                        {
                            NotifySuccess($"{identityRole.Name} ویرایش شد");

                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد:{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _roleManager.Roles.ToList());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", identityRole);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(string id)
        {
            try
            {
                var role = _roleManager.Roles.FirstOrDefault(p => p.Id.CompareTo(id) == 0);
                var name = role.Name;
                var response = _roleManager.DeleteAsync(role);
                if (!response.Result.Succeeded)
                {
                    NotifyErrors(new List<string>() { "حذف اطلاعات انجام نشد" });
                }
                else
                {
                    NotifySuccess($"{name} حذف شد");

                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _roleManager.Roles.ToList());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
