using Microsoft.EntityFrameworkCore.Migrations;

namespace Class.EF.Example2.Migrations
{
    public partial class CourseLecturerOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses");

            migrationBuilder.AlterColumn<long>(
                name: "LecturerId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses");

            migrationBuilder.AlterColumn<long>(
                name: "LecturerId",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
