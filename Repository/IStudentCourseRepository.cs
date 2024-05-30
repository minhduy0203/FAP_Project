using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IStudentCourseRepository
    {

        public IQueryable<StudentCourse> List();
        public StudentCourse Get(int studentId, int courseId);

        public StudentCourse Add(StudentCourse studentCourse);
        public StudentCourse Delete(int studentId, int courseId);
        public StudentCourse Update(StudentCourse studentCourse);
    }
}
