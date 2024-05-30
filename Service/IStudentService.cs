using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IStudentService
    {
        StudentDTO Get(int id);
        List<StudentDTO> List();

        StudentDTO Add(Student student);
        StudentDTO Delete(int id);

        StudentDTO Update(Student student);
    }
}
