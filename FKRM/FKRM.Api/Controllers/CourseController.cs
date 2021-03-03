using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseService.GetAll();
            return Ok(courses);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var course = _courseService.GetById(id);
            return Ok(course);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Register(courseViewModel);
            return Ok(courseViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] CourseViewModel courseViewModel)
        {
            if (id != courseViewModel.Id)
            {
                return BadRequest();
            }
            _courseService.Update(courseViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _courseService.Remove(id);
            return Ok();
        }
    }
}
