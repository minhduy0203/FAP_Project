using AttendanceMananagmentProject.Models;
using System.ComponentModel;

namespace AttendanceMananagmentProject.Dto.StudentSchedules
{
    public class StudentSchedulesDTO
    {
        public int StudentId { get; set; }
        public int ScheduleId { get; set; }
        public Status Status { get; set; }
    }
}
