using FKRM.Domain.Constants;
using FKRM.Infra.Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin)]
    public class UserRolesController : BaseController<UserRolesController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserRolesController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IToastNotification toastNotification) : base(toastNotification)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> LoadAllAsync()
        {
            List<UserRolesViewModel> userRolesViewModel = await GetUsers();
            return PartialView("_ViewAll", userRolesViewModel);
        }
        private async Task<List<UserRolesViewModel>> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.Id = user.Id;
                thisViewModel.UserName = user.UserName;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.IsActive = user.IsActive;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return userRolesViewModel;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreate()
        {
            return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", new RegisterUserViewModel()) }); 
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreate(RegisterUserViewModel registerUserViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FirstName = registerUserViewModel.FirstName,
                    LastName = registerUserViewModel.LastName,
                    UserName = registerUserViewModel.EmployeeId,
                    Email = registerUserViewModel.EmployeeId+"@gmail.com",
                    EmployeeId = registerUserViewModel.EmployeeId
                };
                var result = await _userManager.CreateAsync(user, registerUserViewModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Roles.Basic.ToString());
                    NotifySuccess($"{registerUserViewModel.FirstName} {registerUserViewModel.LastName} ثبت شد");

                    List<UserRolesViewModel> userRolesViewModel = await GetUsers();

                    var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", userRolesViewModel);
                    return new JsonResult(new { isValid = true, html });
                }
                else
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.");
                    foreach (var error in result.Errors)
                    {
                        NotifyError(error.Description);
                    }
                    var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", registerUserViewModel);
                    return new JsonResult(new { isValid = false, html });
                }
            }
            else {
                List<UserRolesViewModel> userRolesViewModel = await GetUsers();
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", userRolesViewModel);
                return new JsonResult(new { isValid = true, html });
            }
        }
        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }
        public async Task<IActionResult> Manage(string Id)
        {
            ViewBag.Id = Id;
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {Id} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user.UserName;
            var model = new List<ManageUserRolesViewModel>();
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new ManageUserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(new ManageViewModel() { manageUserRoles = model, resetPasswordModel = new ResetPasswordModel() { EmployeeId = user.UserName } });
        }
        [HttpPost]
        public async Task<IActionResult> Manage(ManageViewModel model, string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
                return View();
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                NotifyError($"Cannot remove user existing roles.");
                return View(model);
            }
            result = await _userManager.AddToRolesAsync(user, model.manageUserRoles.Where(x => x.Selected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                NotifyError($"Cannot add selected roles to user.");
                return View(model);
            }
            NotifySuccess($"ثبت اطلاعات انجام شد");
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ManageViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.resetPasswordModel.EmployeeId);
            if (user == null)
            {
                return View();
            }
            string Code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, Code, model.resetPasswordModel.Password);
            if (!result.Succeeded)
            {
                NotifyError($"عملیات مورد نظر انجام نشد.");
                foreach (var error in result.Errors)
                {
                    NotifyError(error.Description);
                }
                return RedirectToAction("Index");
            }
            NotifySuccess($"ثبت اطلاعات انجام شد");
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<JsonResult> OnPostActive(string Id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(Id);
                if (user == null)
                {
                    NotifyError($"Cannot remove user existing roles.");
                }
                else
                {
                    user.IsActive = !user.IsActive;
                    var response=_userManager.UpdateAsync(user);
                    if (response.Result.Succeeded)
                    {
                        NotifySuccess($"تغییر وضعیت انجام شد");
                    }
                }
            }
            catch (Exception ex)
            {
                NotifyError(ex.Message);
            }
            List<UserRolesViewModel> userRolesViewModel = await GetUsers();
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", userRolesViewModel);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
