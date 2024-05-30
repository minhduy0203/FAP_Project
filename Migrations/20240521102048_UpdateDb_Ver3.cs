using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendanceMananagmentProject.Migrations
{
    public partial class UpdateDb_Ver3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "StudentSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "StudentSchedules");
        }
    }
}
