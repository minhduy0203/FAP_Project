using AttendanceMananagmentProject.Dto.Schedule;
using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Dto.StudentSchedules
{
	public class AttendanceDto
	{
	
		public int ScheduleId { get; set; }
		public ScheduleDTO Schedule { get; set; }
		public Status Status { get; set; }
	}
}
