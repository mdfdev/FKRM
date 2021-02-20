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
    [Route("api/[controller]")]
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var Schedules = _scheduleService.GetAll();
            return Ok(Schedules);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var Schedule = _scheduleService.GetById(id);
            return Ok(Schedule);
        }
        [HttpPost]
        public IActionResult Post([FromBody] ScheduleViewModel scheduleViewModel)
        {
            _scheduleService.Register(scheduleViewModel);
            return Ok(scheduleViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] ScheduleViewModel scheduleViewModel)
        {
            if (id != scheduleViewModel.Id)
            {
                return BadRequest();
            }
            _scheduleService.Update(scheduleViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _scheduleService.Remove(id);
            return Ok();
        }
    }
}
