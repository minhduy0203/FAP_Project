using AttendanceMananagmentProject.Dto.Subject;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class SubjectService : ISubjectService
    {
        private ISubjectRepository subjectRepository;
        private IMapper mapper;

        public SubjectService(ISubjectRepository subjectRepository, IMapper mapper)
        {
            this.subjectRepository = subjectRepository;
            this.mapper = mapper;
        }

        public SubjectDTO Add(Subject subject)
        {
            Subject add = subjectRepository.Add(subject);
            return mapper.Map<Subject, SubjectDTO>(add);
        }

        public SubjectDTO Delete(int id)
        {
            Subject delete = subjectRepository.Delete(id);
            return mapper.Map<Subject, SubjectDTO>(delete);
        }

        public SubjectDTO Get(int id)
        {
            Subject subject = subjectRepository.Get(id);
            return mapper.Map<Subject, SubjectDTO>(subject);
        }

        public List<SubjectDTO> List()
        {
            List<Subject> subjects = subjectRepository.List().ToList();
            return mapper.Map<List<Subject>, List<SubjectDTO>>(subjects);
        }

        public SubjectDTO Update(Subject subject)
        {
            Subject update = subjectRepository.Update(subject);
            return mapper.Map<Subject, SubjectDTO>(update);
        }
    }
}
