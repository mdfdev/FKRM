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
    public class OUTypeController : Controller
    {
        private readonly IOUTypeService _oUTypeService;
        public OUTypeController(IOUTypeService oUTypeService)
        {
            _oUTypeService = oUTypeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var oUTypes = _oUTypeService.GetAll();
            return Ok(oUTypes);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var oUType = _oUTypeService.GetById(id);
            return Ok(oUType);
        }
        [HttpPost]
        public IActionResult Post([FromBody] OUTypeViewModel oUTypeViewModel)
        {
            _oUTypeService.Register(oUTypeViewModel);
            return Ok(oUTypeViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] OUTypeViewModel oUTypeViewModel)
        {
            if (id != oUTypeViewModel.Id)
            {
                return BadRequest();
            }
            _oUTypeService.Update(oUTypeViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _oUTypeService.Remove(id);
            return Ok();
        }
    }
}
