using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentController : Controller
    {
        private IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(studentService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(studentService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(studentService.List());

        }

        [HttpPost]
        public IActionResult Add(StudentDTO student)
        {
            return Ok(studentService.Add(student));
        }

        [HttpPut]
        public IActionResult Update(StudentDTO student)
        {
            return Ok(studentService.Update(student));
        }
    }
}
