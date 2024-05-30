using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IStudentCourseRepository
    {

        public IQueryable<StudentCourse> List();
        public StudentCourse Get(int id);

        public StudentCourse Add(StudentCourse course);
        public StudentCourse Delete(StudentCourse course);
        public StudentCourse Update(StudentCourse course);
    }
}
