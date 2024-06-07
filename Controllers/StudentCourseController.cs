using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentCourseController : Controller
    {
        private IStudentCourseService studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            this.studentCourseService = studentCourseService;
        }

        [HttpGet]
        public IActionResult Get(int sid, int cid)
        {
            return Ok(studentCourseService.Get(sid, cid));
        }

        [HttpDelete]
        public IActionResult Delete(int sid, int cid)
        {
            return Ok(studentCourseService.Delete(sid, cid));

        }

        [HttpGet("List")]
        public IActionResult List()
        {
            return Ok(studentCourseService.List());
        }

        [HttpPost("Add")]
        public IActionResult Add(StudentCourse studentCourse)
        {
            return Ok(studentCourseService.Add(studentCourse));
        }

        [HttpPut("Update")]
        public IActionResult Update(StudentCourse studentCourse)
        {
            return Ok(studentCourseService.Update(studentCourse));
        }
    }
}
