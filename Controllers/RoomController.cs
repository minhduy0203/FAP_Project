using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RoomController : Controller
    {
        private IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(roomService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(roomService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(roomService.List());

        }

        [HttpPost]
        public IActionResult Add(RoomDTO room)
        {
            return Ok(roomService.Add(room));
        }

        [HttpPut]
        public IActionResult Update(RoomDTO room)
        {
            return Ok(roomService.Update(room));
        }
    }
}
