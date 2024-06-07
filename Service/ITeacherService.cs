using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Teacher;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface ITeacherService
    {
        TeacherDTO Get(int id);
        List<TeacherDTO> List();

        TeacherDTO Add(TeacherDTO teacher);
        TeacherDTO Delete(int id);

        TeacherDTO Update(TeacherDTO teacher);
    }
}
