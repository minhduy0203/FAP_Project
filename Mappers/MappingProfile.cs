using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Models;
using AutoMapper;

namespace AttendanceMananagmentProject.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>();
            CreateMap<Room,RoomDTO>();
        }
    }
}
