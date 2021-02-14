using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : Controller
    {
        private readonly IGenderService _genderService;
        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var genders = _genderService.GetAll();
            return Ok(genders);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var gender = _genderService.GetById(id);
            return Ok(gender);
        }
        [HttpPost]
        public IActionResult Post([FromBody] GenderViewModel genderViewModel)
        {
            _genderService.Register(genderViewModel);
            return Ok(genderViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] GenderViewModel genderViewModel)
        {
            if (id != genderViewModel.Id)
            {
                return BadRequest();
            }
            _genderService.Update(genderViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _genderService.Remove(id);
            return Ok();
        }
    }
}
