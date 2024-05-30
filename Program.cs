using AttendanceMananagmentProject.Mappers;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AttendanceMananagmentProject.Service;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;

namespace AttendanceMananagmentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MyDBContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Mystr")));
            ConfigureService(builder.Services);
            var app = builder.Build();
            //middleware
            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();
            app.Run();
        }

        public static void ConfigureService(IServiceCollection services)
        {
            services
              .AddControllers()
              .AddOData(opt => opt.Select().Filter().Expand().OrderBy());
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







        }
    }
}