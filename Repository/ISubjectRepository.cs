using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface ISubjectRepository
    {

        public IQueryable<Subject> List();
        public Subject Get(int id);

        public Subject Add(StudentSchedule course);
        public Subject Delete(StudentSchedule course);
        public Subject Update(StudentSchedule course);
    }
}
