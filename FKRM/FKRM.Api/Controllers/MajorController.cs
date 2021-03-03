using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MajorController : Controller
    {
        private readonly IMajorService _majorService;
        public MajorController(IMajorService majorService)
        {
            _majorService = majorService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var Majors = _majorService.GetAll();
            return Ok(Majors);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var Major = _majorService.GetById(id);
            return Ok(Major);
        }
        [HttpPost]
        public IActionResult Post([FromBody] MajorViewModel majorViewModel)
        {
            _majorService.Register(majorViewModel);
            return Ok(majorViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] MajorViewModel majorViewModel)
        {
            if (id != majorViewModel.Id)
            {
                return BadRequest();
            }
            _majorService.Update(majorViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _majorService.Remove(id);
            return Ok();
        }
    }
}
