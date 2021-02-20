using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService =staffService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var staffs = _staffService.GetAll();
            return Ok(staffs);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var staff = _staffService.GetById(id);
            return Ok(staff);
        }
        [HttpPost]
        public IActionResult Post([FromBody] StaffViewModel staffViewModel)
        {
            _staffService.Register(staffViewModel);
            return Ok(staffViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] StaffViewModel staffViewModel)
        {
            if (id != staffViewModel.Id)
            {
                return BadRequest();
            }
            _staffService.Update(staffViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _staffService.Remove(id);
            return Ok();
        }
    }
}
