using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Student;

namespace AttendanceMananagmentProject.Dto.StudentCourse
{
    public class StudentCourseDTO
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public StudentDTO? Student { get; set; }
        public CourseDTO? Course { get; set; }
    }
}
