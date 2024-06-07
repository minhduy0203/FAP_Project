using AttendanceMananagmentProject.Dto.Subject;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMananagmentProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SubjectController : Controller
    {
        private ISubjectService subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(subjectService.Get(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(subjectService.Delete(id));

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(subjectService.List());

        }

        [HttpPost]
        public IActionResult Add(SubjectDTO subject)
        {
            return Ok(subjectService.Add(subject));
        }

        [HttpPut]
        public IActionResult Update(SubjectDTO subject)
        {
            return Ok(subjectService.Update(subject));
        }
    }
}
