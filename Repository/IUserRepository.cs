using AttendanceMananagmentProject.Models;

namespace AttendanceMananagmentProject.Repository
{
    public interface IUserRepository
    {
        User GetUser(string email, string password);
    }
}
