using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IStudentRepository
    {
        public IQueryable<Student> List();
        public Student Get(int id);

        public Student Add(Student course);
        public Student Delete(Student course);
        public Student Update(Student course);
    }
}
