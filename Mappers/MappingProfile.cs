﻿using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Dto.Schedule;
using AttendanceMananagmentProject.Dto.Student;
using AttendanceMananagmentProject.Dto.StudentCourse;
using AttendanceMananagmentProject.Dto.StudentSchedules;
using AttendanceMananagmentProject.Dto.Subject;
using AttendanceMananagmentProject.Dto.Teacher;
using AttendanceMananagmentProject.Models;
using AutoMapper;

namespace AttendanceMananagmentProject.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>();
            CreateMap<Room, RoomDTO>();
            CreateMap<Teacher, TeacherDTO>();
            //.ForMember(dest => dest.Schedules, opt => opt.MapFrom(source => source.Schedules.Select(s => new ScheduleDTO
            //{
            //    Course = new CourseDTO { Code = s.Course.Code, Name = s.Course.Name },
            //    CourseId = s.CourseId,
            //    Id = s.Id,
            //}

            //    )));


            CreateMap<Student, StudentDTO>().ForMember(dest => dest.StudentSchedules,
                opt => opt.MapFrom(src => src.StudentSchedules.Select(ss => new StudentSchedulesDTO
                {
                    ScheduleId = ss.ScheduleId,
                    Status = ss.Status,
                    StudentId = ss.StudentId,
                })));
            CreateMap<Schedule, ScheduleDTO>()
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => new CourseDTO
                {
                    Code = src.Course.Code,
                    Name = src.Course.Name,
                    StartDate = src.Course.StartDate,
                    TimeSlot = src.Course.TimeSlot,
                    //Subject = new SubjectDTO { Name = src.Course.Subject.Name}


                }))
                .ForMember(dest => dest.StudentSchedules, opt => opt.MapFrom(src => src.StudentSchedules.Select(ss => new StudentSchedulesDTO { ScheduleId = ss.ScheduleId,StudentId = ss.StudentId,Status =ss.Status})));
            CreateMap<Subject, SubjectDTO>();
            CreateMap<StudentCourse, StudentCourseDTO>()
                .ForMember(dest => dest.Student, opt => opt.MapFrom(src => new StudentDTO
                {
                    Id = src.StudentId,
                    Code = src.Student.Code,
                    Name = src.Student.Name,
                    Email = src.Student.Email,
                }))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => new CourseDTO
                {
                    Code = src.Course.Code,
                    Name = src.Course.Name,
                    StartDate = src.Course.StartDate,
                    EndDate = src.Course.EndDate,

                }))
                ;
            CreateMap<StudentSchedule, StudentSchedulesDTO>();


            CreateMap<StudentDTO, Student>()
               .ForMember(dest => dest.StudentSchedules , opt => opt.Condition(src => src.StudentSchedules != null && src.StudentSchedules?.Count != 0));

            CreateMap<RoomDTO, Room>();
            CreateMap<TeacherDTO, Teacher>();
            CreateMap<SubjectDTO, Subject>();
            CreateMap<StudentSchedulesDTO, StudentSchedule>();
        }
    }
}
