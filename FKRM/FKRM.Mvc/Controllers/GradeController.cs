using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class GradeController : Controller
    {
        private IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        public IActionResult Index()
        {
            var model = new GradeViewModel();
            return View(model);
        }
        //public async Task<IActionResult> LoadAll()
        //{
        //    var response = await _mediator.Send(new GetAllBrandsCachedQuery());
        //    if (response.Succeeded)
        //    {
        //        var viewModel = _mapper.Map<List<BrandViewModel>>(response.Data);
        //        return PartialView("_ViewAll", viewModel);
        //    }
        //    return null;
        //}
    }
}
