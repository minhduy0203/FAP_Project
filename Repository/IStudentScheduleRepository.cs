using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IStudentScheduleRepository
    {
        public IQueryable<StudentSchedule> List();
        public StudentSchedule Get(int studentId, int scheduleId);

        public StudentSchedule Add(StudentSchedule studentSchedule);
        public StudentSchedule Delete(int studentId, int scheduleId);
        public StudentSchedule Update(StudentSchedule studentSchedule);
    }
}
