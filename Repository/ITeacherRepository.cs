using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface ITeacherRepository
    {
        public IQueryable<Teacher> List();
        public Teacher Get(int id);

        public Teacher Add(Teacher teacher);
        public Teacher Delete(int id);
        public Teacher Update(Teacher teacher);
    }
}
