using AttendanceMananagmentProject.Dto.Schedule;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class ScheduleService : IScheduleService
    {

        private IScheduleRepository scheduleRepository;
        private IMapper mapper;

        public ScheduleService(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            this.scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        public ScheduleDTO Add(Schedule schedule)
        {
            scheduleRepository.Add(schedule);
            return mapper.Map<Schedule, ScheduleDTO>(schedule);
        }

        public ScheduleDTO Delete(int id)
        {
            Schedule schedule = scheduleRepository.Delete(id);
            return mapper.Map<Schedule, ScheduleDTO>(schedule);
        }

        public ScheduleDTO Get(int id)
        {
            Schedule schedule = scheduleRepository.Get(id);
            return mapper.Map<Schedule, ScheduleDTO>(schedule);
        }

        public List<ScheduleDTO> List()
        {
            List<Schedule> schedules = scheduleRepository.List().ToList();
            return mapper.Map<List<Schedule>, List<ScheduleDTO>>(schedules);
        }

        public ScheduleDTO Update(Schedule schedule)
        {
            Schedule update = scheduleRepository.Update(schedule);
            return mapper.Map<Schedule, ScheduleDTO>(update);
        }
    }
}
