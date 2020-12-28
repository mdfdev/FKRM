using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenderController : Controller
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] GenderViewModel genderViewModel)
        {
            _genderService.Create(genderViewModel);
            return Ok(genderViewModel);
        }
    }
}
