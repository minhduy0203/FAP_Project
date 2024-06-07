using AttendanceMananagmentProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace AttendanceMananagmentProject.Controllers
{
    public class RoomsController : ODataController
    {
        private MyDBContext dBContext;

        public RoomsController(MyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(dBContext.Rooms);
        }


    }
}
