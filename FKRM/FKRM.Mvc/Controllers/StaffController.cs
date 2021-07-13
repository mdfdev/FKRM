using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Globalization;
using System.Threading.Tasks;
namespace FKRM.Mvc.Controllers
{
    public class StaffController : BaseController<StaffController>
    {
        private readonly IStaffService _staffService;
        private readonly IJobTitleService _jobTitleService;
        private readonly ISchoolService _schoolService;
        private readonly IAcademicCalendarService _academicCalendarService;
        private readonly IAcademicDegreeService _academicDegreeService;
        private readonly IAcademicMajorService _academicMajorService;
        private readonly IStaffEducationalBackgroundService _staffEducationalBackgroundService;
        public StaffController(IStaffService staffService, IAcademicCalendarService academicCalendarService, ISchoolService schoolService,
            IJobTitleService jobTitleService, IToastNotification toastNotification, IAcademicDegreeService academicDegreeService,
            IAcademicMajorService academicMajorService,IStaffEducationalBackgroundService staffEducationalBackgroundService) : base(toastNotification)
        {
            _staffEducationalBackgroundService = staffEducationalBackgroundService;
            _academicMajorService = academicMajorService;
            _academicDegreeService = academicDegreeService;
            _staffService = staffService;
            _schoolService = schoolService;
            _academicCalendarService = academicCalendarService;
            _jobTitleService = jobTitleService;
        }
        public JsonResult Profile(Guid id)
        {
            var  staffEducationalBackgrounds = _staffEducationalBackgroundService.GetAllDataByStaffId(id).Result.Data;
            var   staffViewModel = _staffService.GetAllDataById(id).Result.Data;
            staffViewModel.staffEducationalBackgrounds = staffEducationalBackgrounds;
            return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("Profile",staffViewModel) });
        }
        public IActionResult LoadAll(Guid id)
        {
            return PartialView("_ViewAll", _staffService.GetAllData(id).Result.Data);
        }
        public IActionResult Index()
        {
            PersianCalendar pc = new PersianCalendar();
            var pYear = pc.GetYear(DateTime.Now).ToString();
            var academicCalendarViewModels = _academicCalendarService.GetAllWithTitle();
            ViewData["AcademicCalendars"] = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", _academicCalendarService.GetByYear(pYear).Id, null);
            return View();
        }
        public JsonResult GetStaff(string id)
        {
            return new JsonResult(_staffService.GetAllDataByNid(id).Result.Data);
        }
        public JsonResult OnGetCreateEducationalBackground(Guid StaffId = default)
        {

            var staffEducationalBackgroundViewModel = new StaffEducationalBackgroundViewModel();
            staffEducationalBackgroundViewModel.StaffId = StaffId;
            var academicDegreeViewModels = _academicDegreeService.GetAll();
            var academicMajorViewModels = _academicMajorService.GetAll();
            staffEducationalBackgroundViewModel.AcademicMajors = new SelectList(academicMajorViewModels, "Id", "Name", null, null);
            staffEducationalBackgroundViewModel.AcademicDegrees = new SelectList(academicDegreeViewModels, "Id", "Name", null, null);

            return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateEducationalBackground", staffEducationalBackgroundViewModel) });

        }
        [HttpPost]
        public async Task<JsonResult> OnGetCreateEducationalBackground(Guid StaffId, StaffEducationalBackgroundViewModel educationalBackgroundViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (StaffId != Guid.Empty)
                    {
                        var response = _staffEducationalBackgroundService.Register(educationalBackgroundViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"سابقه تحصیلی ثبت شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
            }
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            PersianCalendar pc = new PersianCalendar();
            var pYear = pc.GetYear(DateTime.Now).ToString();
            if (id == Guid.Empty)
            {
                var staffViewModel = new StaffViewModel();
                var jobTitleViewModels = _jobTitleService.GetAll();
                var schoolViewModels = _schoolService.GetAllWithCode();
                var academicCalendarViewModels = _academicCalendarService.GetAllWithTitle();
                staffViewModel.AcademicCalendars = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", _academicCalendarService.GetByYear(pYear).Id, null);
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
                staffViewModel.AcademicCalendars = new SelectList(academicCalendarViewModels, "Id", "AcademicYear", _academicCalendarService.GetByYear(pYear).Id, null);
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
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAllData(staffViewModel.AcademicCalendarId).Result.Data);
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
            Guid acId = Guid.Empty;
            try
            {
                var tmp = _staffService.GetAllDataById(id);
                acId = tmp.Result.Data.AcademicCalendarId;
                var name = $"{tmp.Result.Data.FirstName} {tmp.Result.Data.LastName}";
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _staffService.GetAllData(acId).Result.Data);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
