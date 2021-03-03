using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : Controller
    {
        private readonly IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var grades = _gradeService.GetAll();
            return Ok(grades);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var grade = _gradeService.GetById(id);
            return Ok(grade);
        }
        [HttpPost]
        public IActionResult Post([FromBody] GradeViewModel gradeViewModel)
        {
            _gradeService.Register(gradeViewModel);
            return Ok(gradeViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] GradeViewModel gradeViewModel)
        {
            if (id != gradeViewModel.Id)
            {
                return BadRequest();
            }
            _gradeService.Update(gradeViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _gradeService.Remove(id);
            return Ok();
        }
    }
}
