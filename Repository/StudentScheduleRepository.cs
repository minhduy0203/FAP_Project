using AttendanceMananagmentProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceMananagmentProject.Repository
{
    public class StudentScheduleRepository : IStudentScheduleRepository
    {
        private MyDBContext dBContext;

        public StudentScheduleRepository(MyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public StudentSchedule Add(StudentSchedule studentSchedule)
        {
            dBContext.StudentSchedules.Add(studentSchedule);
            dBContext.SaveChanges();
            return studentSchedule;
        }

        public StudentSchedule Delete(int studentId, int scheduleId)
        {
            StudentSchedule studentSchedule = dBContext.StudentSchedules.FirstOrDefault(ss => ss.StudentId == studentId && ss.ScheduleId == scheduleId);
            if (studentSchedule != null)
            {
                dBContext.StudentSchedules.Remove(studentSchedule);
                dBContext.SaveChanges();
            }
            return studentSchedule;
        }

        public StudentSchedule Get(int studentId, int scheduleId)
        {
            return dBContext.StudentSchedules
                .Include(ss => ss.Schedule)
                .FirstOrDefault(ss => ss.StudentId == studentId && ss.ScheduleId == scheduleId);
        }

        public IQueryable<StudentSchedule> List()
        {
            return dBContext.StudentSchedules.AsQueryable();

        }

        public StudentSchedule Update(StudentSchedule studentSchedule)
        {
            StudentSchedule update = dBContext.StudentSchedules.FirstOrDefault(ss => ss.StudentId == studentSchedule.StudentId && ss.ScheduleId == studentSchedule.ScheduleId);
            if (studentSchedule != null)
            {
                dBContext.StudentSchedules.Add(studentSchedule);
                dBContext.Entry(studentSchedule).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            return studentSchedule;
        }

        public StudentSchedule UpdateStudentAttendance(int studentId, int scheduleId, Status status)
        {
            StudentSchedule update = dBContext.StudentSchedules.FirstOrDefault(ss => ss.StudentId == studentId && ss.ScheduleId == scheduleId);
            if (update != null)
            {
                update.Status = status;
                dBContext.SaveChanges();
            }
            return update;
        }
    }
}
