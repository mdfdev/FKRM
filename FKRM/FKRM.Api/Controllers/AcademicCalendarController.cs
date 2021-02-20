using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcademicCalendarController : Controller
    {
        private readonly IAcademicCalendarService _academicCalendarService;
        public AcademicCalendarController(IAcademicCalendarService academicCalendarService)
        {
            _academicCalendarService = academicCalendarService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var academicCalendars = _academicCalendarService.GetAll();
            return Ok(academicCalendars);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var academicCalendar = _academicCalendarService.GetById(id);
            return Ok(academicCalendar);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AcademicCalendarViewModel academicCalendarViewModel)
        {
            _academicCalendarService.Register(academicCalendarViewModel);
            return Ok(academicCalendarViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] AcademicCalendarViewModel academicCalendarViewModel)
        {
            if (id != academicCalendarViewModel.Id)
            {
                return BadRequest();
            }
            _academicCalendarService.Update(academicCalendarViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _academicCalendarService.Remove(id);
            return Ok();
        }
    }
}
