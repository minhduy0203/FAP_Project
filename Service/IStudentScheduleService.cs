using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.StudentSchedules;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IStudentScheduleService
    {
        StudentSchedulesDTO Get(int studentId, int scheduleId);
        List<StudentSchedulesDTO> List();

        StudentSchedulesDTO Add(StudentSchedule studentSchedule);
        StudentSchedulesDTO Delete(int studentId, int scheduleId);

        StudentSchedulesDTO Update(StudentSchedule studentSchedule);
    }
}
