using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class CourseController : BaseController<CourseController>
    {
        private readonly ICourseService _courseService;
        private readonly IBranchService _branchService;
        private readonly IGradeService _gradeService;
        private readonly IMarkingTypeService _markingTypeService;
        public CourseController(ICourseService courseService, IBranchService branchService, IGradeService gradeService, IMarkingTypeService markingTypeService , IToastNotification toastNotification) : base(toastNotification)
        {
            _courseService = courseService;
            _branchService = branchService;
            _gradeService = gradeService;
            _markingTypeService = markingTypeService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _courseService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var courseViewModel = new CourseViewModel();
                var branchViewModels = _branchService.GetAll();
                var gradeViewModels= _gradeService.GetAll();
                var markingTypeViewModels = _markingTypeService.GetAll();
                courseViewModel.Branches = new SelectList(branchViewModels, "Id", "Name", null, null);
                courseViewModel.Grades = new SelectList(gradeViewModels, "Id", "Name", null, null);
                courseViewModel.MarkingTypes = new SelectList(markingTypeViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", courseViewModel) });
            }
            else
            {
                var courseViewModel = _courseService.GetById(id);
                var branchViewModels = _branchService.GetAll();
                var gradeViewModels = _gradeService.GetAll();
                var markingTypeViewModels = _markingTypeService.GetAll();
                courseViewModel.Branches = new SelectList(branchViewModels, "Id", "Name", null, null);
                courseViewModel.Grades = new SelectList(gradeViewModels, "Id", "Name", null, null);
                courseViewModel.MarkingTypes = new SelectList(markingTypeViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", courseViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _courseService.Register(courseViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{courseViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _courseService.Update(courseViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{courseViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _courseService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", courseViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _courseService.GetById(id).Name;
                var response = _courseService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _courseService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
