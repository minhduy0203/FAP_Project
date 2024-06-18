using AttendanceMananagmentProject.Dto;
using AttendanceMananagmentProject.Dto.User;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OData.UriParser;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AttendanceMananagmentProject.Controllers
{

	[ApiController]
	[Route("/api/[controller]")]
	public class UserController : Controller
	{
		private IUserService userService;
		private IConfiguration configuration;

		public UserController(IUserService userService, IConfiguration configuration)
		{
			this.userService = userService;
			this.configuration = configuration;
		}

		[HttpPost("Login")]
		public IActionResult Login(LoginRequest request)
		{
			Models.User u = userService.Login(request.Email, request.Password);
			if (u != null)
			{
				List<Claim> claims = new List<Claim>()
				{
					new Claim(ClaimTypes.Name, u.Email),
					new Claim(ClaimTypes.Role,u.Role.Name)
				};

				if (u.Role.Name == "STUDENT")
				{
					claims.Add(new Claim("Id", u.StudentId.ToString()));
				}
				else if (u.Role.Name == "TEACHER")
				{
					claims.Add(new Claim("Id", u.TeacherId.ToString()));

				}

				var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
				var expiry = DateTime.Now.AddDays(Convert.ToInt32(configuration["Jwt:ExpiryInDays"]));
				var token = new JwtSecurityToken(
					configuration["Jwt:Issuer"],
					configuration["Jwt:Audience"],
					claims,
					expires: expiry,
					signingCredentials: creds
					);

				return Ok(new Response<LoginResponse>
				{
					Message = "Login successfully",
					Data = new LoginResponse { Token = new JwtSecurityTokenHandler().WriteToken(token) }
				});

			}
			else
			{
				return Ok(new Response<LoginResponse>
				{
					Message = "Login failed",
					Data = null
				});
			}
		}
	}
}
