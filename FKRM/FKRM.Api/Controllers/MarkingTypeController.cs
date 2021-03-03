using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarkingTypeController : Controller
    {
        private readonly IMarkingTypeService _markingTypeService;
        public MarkingTypeController(IMarkingTypeService markingTypeService)
        {
            _markingTypeService = markingTypeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var MarkingTypes = _markingTypeService.GetAll();
            return Ok(MarkingTypes);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var MarkingType = _markingTypeService.GetById(id);
            return Ok(MarkingType);
        }
        [HttpPost]
        public IActionResult Post([FromBody] MarkingTypeViewModel markingTypeViewModel)
        {
            _markingTypeService.Register(markingTypeViewModel);
            return Ok(markingTypeViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] MarkingTypeViewModel markingTypeViewModel)
        {
            if (id != markingTypeViewModel.Id)
            {
                return BadRequest();
            }
            _markingTypeService.Update(markingTypeViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _markingTypeService.Remove(id);
            return Ok();
        }
    }
}
