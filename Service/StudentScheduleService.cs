using AttendanceMananagmentProject.Dto.StudentSchedules;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class StudentScheduleService : IStudentScheduleService
    {
        private IStudentScheduleRepository studentScheduleRepository;
        private IMapper mapper;

        public StudentScheduleService(IStudentScheduleRepository studentScheduleRepository, IMapper mapper)
        {
            this.studentScheduleRepository = studentScheduleRepository;
            this.mapper = mapper;
        }

        public StudentSchedulesDTO Add(StudentSchedule studentSchedule)
        {
            studentScheduleRepository.Add(studentSchedule);
            return mapper.Map<StudentSchedule, StudentSchedulesDTO>(studentSchedule);
        }

        public StudentSchedulesDTO Delete(int studentId, int scheduleId)
        {
            StudentSchedule studentSchedule = studentScheduleRepository.Delete(studentId, scheduleId);
            return mapper.Map<StudentSchedule, StudentSchedulesDTO>(studentSchedule);
        }

        public StudentSchedulesDTO Get(int studentId, int scheduleId)
        {
            StudentSchedule studentSchedule = studentScheduleRepository.Get(studentId, scheduleId);
            return mapper.Map<StudentSchedule, StudentSchedulesDTO>(studentSchedule);
        }

        public List<StudentSchedulesDTO> List()
        {
            List<StudentSchedule> studentSchedule = studentScheduleRepository.List().ToList();
            return mapper.Map<List<StudentSchedule>, List<StudentSchedulesDTO>>(studentSchedule);
        }

        public StudentSchedulesDTO Update(StudentSchedule studentSchedule)
        {
            StudentSchedule update = studentScheduleRepository.Update(studentSchedule);
            return mapper.Map<StudentSchedule, StudentSchedulesDTO>(update);
        }
    }
}
