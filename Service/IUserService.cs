using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Service
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}
