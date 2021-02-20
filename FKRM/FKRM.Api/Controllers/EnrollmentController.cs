using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var enrollments = _enrollmentService.GetAll();
            return Ok(enrollments);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var enrollment = _enrollmentService.GetById(id);
            return Ok(enrollment);
        }
        [HttpPost]
        public IActionResult Post([FromBody] EnrollmentViewModel enrollmentViewModel)
        {
            _enrollmentService.Register(enrollmentViewModel);
            return Ok(enrollmentViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] EnrollmentViewModel enrollmentViewModel)
        {
            if (id != enrollmentViewModel.Id)
            {
                return BadRequest();
            }
            _enrollmentService.Update(enrollmentViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _enrollmentService.Remove(id);
            return Ok();
        }
    }
}
