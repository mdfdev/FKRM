using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class StaffController : BaseController<StaffController>
    {
        private readonly IStaffService _staffService;
        private readonly IJobTitleService _jobTitleService;
        private readonly ISchoolService _schoolService;
        private readonly IAcademicCalendarService _academicCalendarService;

        public StaffController(IStaffService staffService,IAcademicCalendarService academicCalendarService,ISchoolService schoolService,IJobTitleService jobTitleService, IToastNotification toastNotification) : base(toastNotification)
        {
            _staffService = staffService;
            _schoolService = schoolService;
            _academicCalendarService = academicCalendarService;
            _jobTitleService = jobTitleService;
        }
        public IActionResult LoadAll(Guid id)
        {
            return PartialView("_ViewAll", _staffService.GetAllData(id).Result.Data);
        }
        public IActionResult Index()
        {
            var academicCalendarViewModels = _academicCalendarService.GetAllWithTitle();
            ViewData["AcademicCalendars"] = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", null, null);
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var staffViewModel = new StaffViewModel();
                var jobTitleViewModels = _jobTitleService.GetAll();
                var schoolViewModels = _schoolService.GetAllWithCode();
                var academicCalendarViewModels = _academicCalendarService.GetAllWithTitle();
                staffViewModel.AcademicCalendars = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", null, null);
                staffViewModel.JobTitles = new SelectList(jobTitleViewModels, "Id", "Title", null, null);
                staffViewModel.Schools = new SelectList(schoolViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", staffViewModel) });
            }
            else
            {
                var staffViewModel = _staffService.GetById(id);
                var jobTitleViewModels = _jobTitleService.GetAll();
                var schoolViewModels = _schoolService.GetAllWithCode();
                var academicCalendarViewModels = _academicCalendarService.GetAllWithTitle();
                staffViewModel.AcademicCalendars = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", null, null);
                staffViewModel.Schools = new SelectList(schoolViewModels, "Id", "Name", null, null);
                staffViewModel.JobTitles = new SelectList(jobTitleViewModels, "Id", "Title", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", staffViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, StaffViewModel staffViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _staffService.Register(staffViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{staffViewModel.FirstName} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _staffService.Update(staffViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{staffViewModel.FirstName} {staffViewModel.LastName} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", staffViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var tmp = _staffService.GetById(id);
                var name = $"{tmp.FirstName} {tmp.LastName}";
                var response = _staffService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
