using System.ComponentModel.DataAnnotations;

namespace AttendanceMananagmentProject.Dto.User
{
    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
