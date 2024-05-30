using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IScheduleRepository
    {

        public IQueryable<Schedule> List();
        public Schedule Get(int id);

        public Schedule Add(Schedule course);
        public Schedule Delete(Schedule course);
        public Schedule Update(Schedule course);
    }
}
