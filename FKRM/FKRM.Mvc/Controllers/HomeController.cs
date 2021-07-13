using FKRM.Application.Interfaces;
using FKRM.Domain.Constants;
using FKRM.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using System.Diagnostics;

namespace FKRM.Mvc.Controllers
{
    [Authorize(Roles = Roles.Basic)]
    public class HomeController : BaseController<HomeController> 
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStaffService _staffService;
        private readonly ISchoolService _schoolService;
        private readonly IMajorService _majorService;
        public HomeController(ILogger<HomeController> logger, 
            ISchoolService schoolService,
            IMajorService majorService,
            IStaffService staffService,IToastNotification toastNotification) : base(toastNotification)
        {
            _logger = logger;
            _majorService = majorService;
            _schoolService = schoolService;
            _staffService = staffService;
        }

        public IActionResult Index()
        {

            ViewBag.Staffs = _staffService.Count();
            ViewBag.Schools = _schoolService.Count();
            ViewBag.Majors = _majorService.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
