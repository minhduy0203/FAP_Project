using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendanceMananagmentProject.Migrations
{
    public partial class UpdateDb_Ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Code", "Email", "Name" },
                values: new object[] { 1, "HE172040", null, "Minh Duy" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "NumberSlot" },
                values: new object[] { 1, "C# programming", 20 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "ChiLP", "Le Phuong Chi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");
        }
    }
}
