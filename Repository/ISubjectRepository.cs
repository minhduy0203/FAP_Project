using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface ISubjectRepository
    {

        public IQueryable<Subject> List();
        public Subject Get(int id);

        public Subject Add(Subject subject);
        public Subject Delete(int id);
        public Subject Update(Subject course);
    }
}
