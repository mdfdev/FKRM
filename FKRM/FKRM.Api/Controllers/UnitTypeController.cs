using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitTypeController : Controller
    {
        private readonly IUnitTypeService _unitTypeService;
        public UnitTypeController(IUnitTypeService UnitTypeService)
        {
            _unitTypeService = UnitTypeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var unitTypes = _unitTypeService.GetAll();
            return Ok(unitTypes);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var UnitType = _unitTypeService.GetById(id);
            return Ok(UnitType);
        }
        [HttpPost]
        public IActionResult Post([FromBody] UnitTypeViewModel unitTypeViewModel)
        {
            _unitTypeService.Register(unitTypeViewModel);
            return Ok(unitTypeViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] UnitTypeViewModel unitTypeViewModel)
        {
            if (id != unitTypeViewModel.Id)
            {
                return BadRequest();
            }
            _unitTypeService.Update(unitTypeViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _unitTypeService.Remove(id);
            return Ok();
        }
    }
}
