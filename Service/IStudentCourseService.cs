using AttendanceMananagmentProject.Dto.Course;
using AttendanceMananagmentProject.Dto.StudentCourse;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
	public interface IStudentCourseService
	{
		StudentCourseDTO Get(int sid, int cid);
		List<StudentCourseDTO> List();

		StudentCourseDTO Add(StudentCourse sc);
		StudentCourseDTO Delete(int sid, int cid);

		StudentCourseDTO Update(StudentCourse sc);
		List<StudentCourseDTO> ListByStudentId(int id);

	}
}
