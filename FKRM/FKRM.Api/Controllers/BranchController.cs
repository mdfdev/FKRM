using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }
        [HttpGet]
        [SwaggerOperation(
            Summary = "نمایش عناوین شاخه ها",
            Description = "لیست شاخه ها را نمایش می دهد" )]
        public IActionResult GetAll()
        {
            var branchs = _branchService.GetAll();
            return Ok(branchs);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var branch = _branchService.GetById(id);
            return Ok(branch);
        }
        [HttpPost]
        public IActionResult Post([FromBody] BranchViewModel branchViewModel)
        {
            _branchService.Register(branchViewModel);
            return Ok(branchViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] BranchViewModel branchViewModel)
        {
            if (id != branchViewModel.Id)
            {
                return BadRequest();
            }
            _branchService.Update(branchViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _branchService.Remove(id);
            return Ok();
        }
    }
}
