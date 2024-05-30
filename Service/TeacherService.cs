using AttendanceMananagmentProject.Dto.Teacher;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository teacherRepository;
        private IMapper mapper;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            this.teacherRepository = teacherRepository;
            this.mapper = mapper;
        }

        public TeacherDTO Add(Teacher teacher)
        {
            Teacher add = teacherRepository.Add(teacher);
            return mapper.Map<Teacher, TeacherDTO>(teacher);
        }

        public TeacherDTO Delete(int id)
        {
            Teacher delete = teacherRepository.Delete(id);
            return mapper.Map<Teacher, TeacherDTO>(delete);
        }

        public TeacherDTO Get(int id)
        {
            Teacher teacher = teacherRepository.Get(id);
            return mapper.Map<Teacher, TeacherDTO>(teacher);
        }

        public List<TeacherDTO> List()
        {
            List<Teacher> teachers = teacherRepository.List().ToList();
            return mapper.Map<List<Teacher>, List<TeacherDTO>>(teachers);
        }

        public TeacherDTO Update(Teacher teacher)
        {
            Teacher update = teacherRepository.Update(teacher);
            return mapper.Map<Teacher, TeacherDTO>(update);
        }
    }
}
