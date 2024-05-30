using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Schedule;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IScheduleService
    {
        ScheduleDTO Get(int id);
        List<ScheduleDTO> List();

        ScheduleDTO Add(Schedule schedule);
        ScheduleDTO Delete(int id);

        ScheduleDTO Update(Schedule schedule);
    }
}
