using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IStudentService
    {
        StudentDTO Get(int id);
        List<StudentDTO> List();

        StudentDTO Add(StudentDTO student);
        StudentDTO Delete(int id);

        StudentDTO Update(StudentDTO student);
    }
}
