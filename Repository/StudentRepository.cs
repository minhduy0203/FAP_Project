using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private MyDBContext dBContext;

        public StudentRepository(MyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public Student Add(Student student)
        {
            dBContext.Students.Add(student);
            dBContext.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            Student std = dBContext.Students.FirstOrDefault(s => s.Id == id);
            if (std != null)
            {
                dBContext.Students.Remove(std);
                dBContext.SaveChanges();
            }
            return std;
        }

        public Student Get(int id)
        {
            return dBContext.Students.FirstOrDefault(s => s.Id == id);
        }

        public IQueryable<Student> List()
        {
            return dBContext.Students.AsQueryable();

        }

        public Student Update(Student student)
        {
            Student std = dBContext.Students.FirstOrDefault(s => s.Id == student.Id);
            if (std != null)
            {
                dBContext.Students.Add(student);
                dBContext.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            return std;
        }
    }
}
