using FKRM.Domain.Constants;
using FKRM.Infra.Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin)]
    public class RoleManagerController : BaseController<RoleManagerController>
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleManagerController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, 
            IToastNotification toastNotification) : base(toastNotification)
        {
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _roleManager.Roles.ToList());
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(string id)
        {
            if (id == null)
            {
                var identityRole = new IdentityRole();
                identityRole.Id = string.Empty;
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", identityRole) });
            }
            else
            {
                var identityRole =await _roleManager.FindByIdAsync(id);
                if (identityRole == null) NotifyError("Unexpected Error. Role not found!");
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
                        if (response.Result.Succeeded)
                        {
                            NotifySuccess($"{identityRole.Name} ثبت شد");
                        }
                        else
                        {
                            NotifyErrors(new List<string>() { "ثبت اطلاعات انجام نشد" });
                        }
                    }
                    else
                    {
                        var existingRole = await _roleManager.FindByIdAsync(identityRole.Id);
                        existingRole.Name = identityRole.Name;
                        existingRole.NormalizedName = identityRole.Name.ToUpper();
                        var response = _roleManager.UpdateAsync(existingRole);
                        if (response.Result.Succeeded)
                        {
                            NotifySuccess($"{identityRole.Name} ویرایش شد");
                        }
                        else
                        {
                            NotifyErrors(new List<string>() { "ثبت اطلاعات انجام نشد" });
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
                var existingRole = _roleManager.Roles.FirstOrDefault(p => p.Id.CompareTo(id) == 0);
                var name = existingRole.Name;
                if (name != "SuperAdmin" && name != "Basic")
                {
                    bool roleIsNotUsed = true;
                    var allUsers =  _userManager.Users.ToList();
                    foreach (var user in allUsers)
                    {
                        if (await _userManager.IsInRoleAsync(user, existingRole.Name))
                        {
                            roleIsNotUsed = false;
                        }
                    }
                    if (roleIsNotUsed)
                    {
                        await _roleManager.DeleteAsync(existingRole);
                        NotifySuccess($"Role {existingRole.Name} deleted.");
                    }
                    else
                    {
                        NotifyError("حذف اطلاعات انجام نشد");
                    }

                }
                else
                {
                    NotifyError($"Not allowed to  delete {name} Role.");
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
