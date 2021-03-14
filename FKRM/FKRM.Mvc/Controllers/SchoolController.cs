using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class SchoolController : BaseController<SchoolController>
    {
        private readonly ISchoolService _schoolService;
        private readonly IGenderService _genderService;
        private readonly IFeatureService _featureService;
        private readonly IOUTypeService _oUTypeService;
        private readonly IUnitTypeService _unitTypeService;
        public SchoolController(ISchoolService schoolService,IUnitTypeService unitTypeService,IOUTypeService oUTypeService,IFeatureService featureService,IGenderService genderService, IToastNotification toastNotification) : base(toastNotification)
        {
            _unitTypeService = unitTypeService;
            _schoolService = schoolService;
            _genderService = genderService;
            _featureService = featureService;
            _oUTypeService = oUTypeService;
        }
        public IActionResult LoadAll()
        {
            return PartialView("_ViewAll", _schoolService.GetAll());
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult OnGetCreateOrEdit(Guid id = default)
        {
            if (id == Guid.Empty)
            {
                var schoolViewModel = new SchoolViewModel();
                var genderViewModels = _genderService.GetAll();
                schoolViewModel.Genders = new SelectList(genderViewModels, "Id", "Name", null, null);
                var featureViewModels = _featureService.GetAll();
                schoolViewModel.Features = new SelectList(featureViewModels, "Id", "Name", null, null);
                var oUTypeViewModels = _oUTypeService.GetAll();
                schoolViewModel.OUTypes = new SelectList(oUTypeViewModels, "Id", "Name", null, null);
                var unitTypeViewModels = _unitTypeService.GetAll();
                schoolViewModel.UnitTypes = new SelectList(unitTypeViewModels, "Id", "Name", null, null);

                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
            }
            else
            {
                var schoolViewModel = _schoolService.GetById(id);
                var genderViewModels = _genderService.GetAll();
                schoolViewModel.Genders = new SelectList(genderViewModels, "Id", "Name", null, null);
                var featureViewModels = _featureService.GetAll();
                schoolViewModel.Features = new SelectList(featureViewModels, "Id", "Name", null, null);
                var oUTypeViewModels = _oUTypeService.GetAll();
                schoolViewModel.OUTypes = new SelectList(oUTypeViewModels, "Id", "Name", null, null);
                var unitTypeViewModels = _unitTypeService.GetAll();
                schoolViewModel.UnitTypes = new SelectList(unitTypeViewModels, "Id", "Name", null, null);
                return new JsonResult(new { isValid = true, html = ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel) });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostCreateOrEdit(Guid id, SchoolViewModel schoolViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id == Guid.Empty)
                    {
                        var response = _schoolService.Register(schoolViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifySuccess($"{schoolViewModel.Name} ثبت شد.");

                        }
                    }
                    else
                    {
                        var response = _schoolService.Update(schoolViewModel);
                        if (response.Result.Data == 400)
                        {
                            NotifyErrors(response.Result.Message);
                        }
                        else
                        {
                            NotifyInfo($"{schoolViewModel.Name} ویرایش شد.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"عملیات مورد نظر انجام نشد.{ex.Message}");
                }
                var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await ViewRenderer.RenderViewToStringAsync("_CreateOrEdit", schoolViewModel);
                return new JsonResult(new { isValid = false, html });
            }
        }
        [HttpPost]
        public async Task<JsonResult> OnPostDelete(Guid id)
        {
            try
            {
                var name = _schoolService.GetById(id).Name;
                var response = _schoolService.Remove(id);
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
            var html = await ViewRenderer.RenderViewToStringAsync("_ViewAll", _schoolService.GetAll());
            return new JsonResult(new { isValid = true, html });
        }
    }
}
