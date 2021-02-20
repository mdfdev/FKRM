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
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService =roomService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var rooms = _roomService.GetAll();
            return Ok(rooms);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var room = _roomService.GetById(id);
            return Ok(room);
        }
        [HttpPost]
        public IActionResult Post([FromBody] RoomViewModel roomViewModel)
        {
            _roomService.Register(roomViewModel);
            return Ok(roomViewModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] RoomViewModel roomViewModel)
        {
            if (id != roomViewModel.Id)
            {
                return BadRequest();
            }
            _roomService.Update(roomViewModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _roomService.Remove(id);
            return Ok();
        }
    }
}
