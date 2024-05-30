using AttendanceMananagmentProject.Dto.Schedule;

namespace AttendanceMananagmentProject.Dto.Teacher
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<ScheduleDTO>? Schedules { get; set; }
    }
}
