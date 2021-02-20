using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var schools = _schoolService.GetAll();
            return Ok(schools);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var school = _schoolService.GetById(id);
            return Ok(school);
        }
        [HttpPost]
        public IActionResult Post([FromBody] SchoolViewModel schoolViewModel)
        {
            _schoolService.Register(schoolViewModel);
            return Ok(schoolViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] SchoolViewModel schoolViewModel)
        {
            if (id != schoolViewModel.Id)
            {
                return BadRequest();
            }
            _schoolService.Update(schoolViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _schoolService.Remove(id);
            return Ok();
        }
    }
}
