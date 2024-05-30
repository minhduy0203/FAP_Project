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

        [HttpPost("Add")]
        public IActionResult Add(Room room)
        {
            return Ok(roomService.Add(room));
        }

        [HttpPost("Update")]
        public IActionResult Update(Room room)
        {
            return Ok(roomService.Update(room));
        }
    }
}
