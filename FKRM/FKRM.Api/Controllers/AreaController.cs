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
    public class AreaController : Controller
    {
        private readonly IAreaService _areaService;
        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var areas = _areaService.GetAll();
            return Ok(areas);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var area = _areaService.GetById(id);
            return Ok(area);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AreaViewModel areaViewModel)
        {
            _areaService.Register(areaViewModel);
            return Ok(areaViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] AreaViewModel areaViewModel)
        {
            if (id != areaViewModel.Id)
            {
                return BadRequest();
            }
            _areaService.Update(areaViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _areaService.Remove(id);
            return Ok();
        }
    }
}
