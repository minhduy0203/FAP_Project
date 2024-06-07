using AttendanceMananagmentProject.Dto.Teacher;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TeacherController : Controller
    {
        private ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(teacherService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(teacherService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(teacherService.List());

        }

        [HttpPost]
        public IActionResult Add(TeacherDTO teacher)
        {
            return Ok(teacherService.Add(teacher));
        }

        [HttpPut]
        public IActionResult Update(TeacherDTO teacher)
        {
            return Ok(teacherService.Update(teacher));
        }
    }
}
