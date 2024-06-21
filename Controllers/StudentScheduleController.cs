using AttendanceMananagmentProject.Dto.StudentSchedules;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
	[ApiController]
	[Route("/api/[controller]")]
	public class StudentScheduleController : Controller
	{
		private IStudentScheduleService studentScheduleService;

		public StudentScheduleController(IStudentScheduleService studentScheduleService)
		{
			this.studentScheduleService = studentScheduleService;
		}

		[HttpGet]
		public IActionResult Get(int studentId, int courseId)
		{
			return Ok(studentScheduleService.Get(studentId, courseId));
		}

		[HttpDelete]
		public IActionResult Delete(int studentId, int courseId)
		{
			return Ok(studentScheduleService.Delete(studentId, courseId));

		}

		[HttpGet("List")]
		public IActionResult List()
		{
			return Ok(studentScheduleService.List());

		}

		[HttpPost]
		public IActionResult Add(StudentSchedulesDTO studentSchedule)
		{
			return Ok(studentScheduleService.Add(studentSchedule));
		}

		[HttpPut]
		public IActionResult Update(StudentSchedulesDTO studentSchedule)
		{
			return Ok(studentScheduleService.Update(studentSchedule));
		}

		[HttpGet("Attend")]
		public IActionResult UpdateAttendance(int studentId, int scheduleId, bool attend)
		{
			return Ok(studentScheduleService.UpdateAttendance(studentId, scheduleId, attend));
		}
		[HttpPost("List/Attend")]
		public IActionResult UpdateListAttendance(StudentScheduleListDto request)
		{
			return Ok(studentScheduleService.AddListAttendanceStudent(request));
		}

		[HttpGet("List/Student")]
		public IActionResult GetStudentSchedule(int sid, int cid)
		{
			return Ok(studentScheduleService.GetListByCourseIdAndStudentId(sid, cid));
		}
	}
}
