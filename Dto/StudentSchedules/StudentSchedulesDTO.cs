using AttendanceMananagmentProject.Dto.Schedule;
using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;
using System.ComponentModel;

namespace AttendanceMananagmentProject.Dto.StudentSchedules
{
    public class StudentSchedulesDTO
    {
        public int StudentId { get; set; }

        public StudentDTO Student { get; set; }
        public int ScheduleId { get; set; }
        public ScheduleDTO Schedule { get; set; }
        public Status Status { get; set; }
    }
}
