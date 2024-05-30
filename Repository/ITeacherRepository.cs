using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface ITeacherRepository
    {
        public IQueryable<Teacher> List();
        public Teacher Get(int id);

        public Teacher Add(Teacher course);
        public Teacher Delete(Teacher course);
        public Teacher Update(Teacher course);
    }
}
