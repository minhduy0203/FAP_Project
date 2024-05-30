using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IStudentScheduleRepository
    {
        public IQueryable<StudentSchedule> List();
        public StudentSchedule Get(int id);

        public StudentSchedule Add(StudentSchedule course);
        public StudentSchedule Delete(StudentSchedule course);
        public StudentSchedule Update(StudentSchedule course);
    }
}
