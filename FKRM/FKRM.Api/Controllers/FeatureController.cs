using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;
        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var features = _featureService.GetAll();
            return Ok(features);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var feature = _featureService.GetById(id);
            return Ok(feature);
        }
        [HttpPost]
        public IActionResult Post([FromBody] FeatureViewModel featureViewModel)
        {
            _featureService.Register(featureViewModel);
            return Ok(featureViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] FeatureViewModel featureViewModel)
        {
            if (id != featureViewModel.Id)
            {
                return BadRequest();
            }
            _featureService.Update(featureViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _featureService.Remove(id);
            return Ok();
        }
    }
}
