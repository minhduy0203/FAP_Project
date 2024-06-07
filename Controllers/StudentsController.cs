using AttendanceMananagmentProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace AttendanceMananagmentProject.Controllers
{
    public class StudentsController : Controller
    {
        private MyDBContext dBContext;

        public StudentsController(MyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [EnableQuery]       
        public IActionResult Get()
        {
            return Ok(dBContext.Students);
        }
    }
}
