using FKRM.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class GenderController : Controller
    {
        private IGenderService _genderService;
        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        public IActionResult Index()
        {
            return View(_genderService.GetGenders());
        }
    }
}
