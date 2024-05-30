using AttendanceMananagmentProject.Dto.Subject;
using AttendanceMananagmentProject.Dto.Teacher;
using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface ISubjectService
    {
        SubjectDTO Get(int id);
        List<SubjectDTO> List();

        SubjectDTO Add(Subject subject);
        SubjectDTO Delete(int id);

        SubjectDTO Update(Subject subject);
    }
}
