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
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService GroupService)
        {
            _groupService = GroupService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var groups = _groupService.GetAll();
            return Ok(groups);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var group = _groupService.GetById(id);
            return Ok(group);
        }
        [HttpPost]
        public IActionResult Post([FromBody] GroupViewModel groupViewModel)
        {
            _groupService.Register(groupViewModel);
            return Ok(groupViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] GroupViewModel groupViewModel)
        {
            if (id != groupViewModel.Id)
            {
                return BadRequest();
            }
            _groupService.Update(groupViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _groupService.Remove(id);
            return Ok();
        }
    }
}
