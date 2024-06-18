using AttendanceMananagmentProject.Dto;
using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.StudentSchedules;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IStudentScheduleService
    {
        StudentSchedulesDTO Get(int studentId, int scheduleId);
        List<StudentSchedulesDTO> List();

        StudentSchedulesDTO Add(StudentSchedulesDTO studentSchedule);
        StudentSchedulesDTO Delete(int studentId, int scheduleId);

        StudentSchedulesDTO Update(StudentSchedulesDTO studentSchedule);

        Response<StudentSchedulesDTO> UpdateAttendance(int studentId, int scheduleId, bool attended);

        Response<List<StudentSchedulesDTO>> AddListAttendanceStudent(StudentScheduleListDto request);

	}
}
