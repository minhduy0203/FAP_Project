using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface ICourseService
    {
        CourseDTO Get(int id);
        List<CourseDTO> List();

        CourseDTO Add(Course course);
        CourseDTO Delete(int id);

        CourseDTO Update(Course course);

    }
}
