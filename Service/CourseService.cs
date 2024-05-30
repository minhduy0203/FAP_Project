using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;
        private IMapper mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            this.courseRepository = courseRepository;
            this.mapper = mapper;
        }

        public CourseDTO Add(Course course)
        {
            Course add = courseRepository.Add(course);
            return mapper.Map<Course, CourseDTO>(add);
        }

        public CourseDTO Delete(int id)
        {
            Course course = courseRepository.Delete(id);
            return mapper.Map<Course, CourseDTO>(course);

        }

        public CourseDTO Get(int id)
        {
            Course course = courseRepository.Get(id);
            return mapper.Map<Course, CourseDTO>(course);

        }

        public List<CourseDTO> List()
        {
            List<Course> courses = courseRepository.List().ToList();
            return mapper.Map<List<Course>, List<CourseDTO>>(courses);
        }

        public CourseDTO Update(Course course)
        {
            Course update = courseRepository.Update(course);
            return mapper.Map<Course, CourseDTO>(update);
        }
    }
}
