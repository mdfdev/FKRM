using FKRM.Application.Interfaces;
using FKRM.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin)]
    public class StaffEducationalBackgroundController :  BaseController<StaffEducationalBackgroundController>
    {
        private readonly IStaffEducationalBackgroundService _staffEducationalBackgroundService;

        public StaffEducationalBackgroundController(IStaffEducationalBackgroundService staffEducationalBackgroundService,
            IToastNotification toastNotification) : base(toastNotification)
        {
            _staffEducationalBackgroundService = staffEducationalBackgroundService;
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var response = _staffEducationalBackgroundService.Remove(id);
                if (response.Result.Data == 400)
                {
                    NotifyErrors(response.Result.Message);
                }
                else
                {
                    NotifyInfo($" حذف شد");
                }
            }
            catch (Exception)
            {
                NotifyError("حذف اطلاعات انجام نشد");
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", "");
            return new JsonResult(new { isValid = true, html});
        }
    }
}
