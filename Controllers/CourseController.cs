using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using AttendanceMananagmentProject.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CourseController : Controller
    {
        private ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(courseService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(courseService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(courseService.List());

        }

        [HttpPost("Add")]
        public IActionResult Add(Course course)
        {
            return Ok(courseService.Add(course));
        }

        [HttpPut("Update")]
        public IActionResult Update(Course course)
        {
            return Ok(courseService.Update(course));
        }

        [HttpPost]
        public IActionResult AddCourse(CourseDTORequest request)
        {
            return Ok(courseService.AddCourse(request));
        }

        [HttpPost("Upload")]
        public IActionResult UploadCourse(IFormFile Upload)
        {
            List<CourseDTORequest> requests = CourseLogic.GetValidCourses(Upload.OpenReadStream());
            string result = courseService.AddByCSV(requests);
            return File(Encoding.UTF8.GetBytes(result.ToString()), "text/csv", "Courses.csv");
        }

    }
}
