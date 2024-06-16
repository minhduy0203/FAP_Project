using AttendanceMananagmentProject.Mappers;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Text;

namespace AttendanceMananagmentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MyDBContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Mystr")));
            ConfigureService(builder.Services);
            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

            var app = builder.Build();
            //middleware
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();
            app.Run();
        }

        public static void ConfigureService(IServiceCollection services)
        {
            services
              .AddControllers()
              .AddOData(opt => opt.Select().Filter().Expand().OrderBy().Count().SetMaxTop(10).AddRouteComponents("odata", GetEdmModel())

              );
            ;

            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IRoomService, RoomService>();

            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ICourseService, CourseService>();

            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<IScheduleService, ScheduleService>();

            services.AddTransient<ITeacherRepository, TeacherRepository>();
            services.AddTransient<ITeacherService, TeacherService>();

            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentService, StudentService>();

            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ISubjectService, SubjectService>();

            services.AddTransient<IStudentCourseRepository, StudentCourseRepository>();
            services.AddTransient<IStudentCourseService, StudentCourseService>();

            services.AddTransient<IStudentScheduleRepository, StudentScheduleRepository>();
            services.AddTransient<IStudentScheduleService, StudentScheduleService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();




        }

        public static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Room>("Rooms");
            builder.EntitySet<StudentSchedule>("StudentSchedules").EntityType.HasKey(ss => new { ss.ScheduleId, ss.StudentId });
            builder.EntitySet<Student>("Students");
            return builder.GetEdmModel();
        }
    }
}