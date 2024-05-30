using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository studentRepository;
        private IMapper mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        public StudentDTO Add(Student student)
        {
            Student add = studentRepository.Add(student);
            return mapper.Map<Student, StudentDTO>(add);
        }

        public StudentDTO Delete(int id)
        {
            Student student = studentRepository.Delete(id);
            return mapper.Map<Student, StudentDTO>(student);

        }

        public StudentDTO Get(int id)
        {
            Student student = studentRepository.Get(id);
            return mapper.Map<Student, StudentDTO>(student);
        }

        public List<StudentDTO> List()
        {
            List<Student> students = studentRepository.List().ToList();
            return mapper.Map<List<Student>, List<StudentDTO>>(students);
        }

        public StudentDTO Update(Student student)
        {
            Student update = studentRepository.Update(student);
            return mapper.Map<Student, StudentDTO>(update);

        }
    }
}
