using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ScheduleController : Controller
    {
        private IScheduleService scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(scheduleService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(scheduleService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(scheduleService.List());

        }

        [HttpGet("Student")]
        public IActionResult GetStudentSchedule(int week, int year, int sid)
        {
            return Ok(scheduleService.ListStudentSchedule(week, year, sid));
        }

        [HttpGet("Teacher")]
        public IActionResult GetTeacherSchedule(int week, int year, int tid)
        {
            return Ok(scheduleService.ListTeacherSchedule(week, year, tid));
        }


        [HttpPost("Add")]
        public IActionResult Add(Schedule schedule)
        {
            return Ok(scheduleService.Add(schedule));
        }

        [HttpPut("Update")]
        public IActionResult Update(Schedule schedule)
        {
            return Ok(scheduleService.Update(schedule));
        }
    }
}
