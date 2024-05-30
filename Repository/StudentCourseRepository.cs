using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private MyDBContext dBContext;

        public StudentCourseRepository(MyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public StudentCourse Add(StudentCourse studentCourse)
        {
            dBContext.StudentCourses.Add(studentCourse);
            dBContext.SaveChanges();
            return studentCourse;
        }

        public StudentCourse Delete(int studentId, int courseId)
        {
            StudentCourse sc = dBContext.StudentCourses.FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);
            if (sc != null)
            {
                dBContext.StudentCourses.Remove(sc);
                dBContext.SaveChanges();
            }
            return sc;
        }

        public StudentCourse Get(int studentId, int courseId)
        {
            return dBContext.StudentCourses.FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);
        }

        public IQueryable<StudentCourse> List()
        {
            return dBContext.StudentCourses.AsQueryable();
        }

        public StudentCourse Update(StudentCourse studentCourse)
        {
            StudentCourse sc = dBContext.StudentCourses.FirstOrDefault(sc => sc.StudentId == studentCourse.StudentId && sc.CourseId == studentCourse.CourseId);
            if (sc != null)
            {
                dBContext.StudentCourses.Add(studentCourse);
                dBContext.Entry(studentCourse).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            return sc;
        }
    }
}
