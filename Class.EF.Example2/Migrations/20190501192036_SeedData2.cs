using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Class.EF.Example2.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LecturerId", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), 1L, "Programming C#" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 2L, "Elementary Database Design" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), 1L, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "StudentInfo",
                columns: new[] { "Id", "Email", "Phone", "StudentId" },
                values: new object[,]
                {
                    { 100L, "martypants@school.example", null, 1L },
                    { 101L, "chrismahs@school.example", "111 11 11 11", 2L },
                    { 102L, "annaf@school.example", "222 22 22 22", 3L },
                    { 103L, "willszeedt@school.example", null, 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 103L);
        }
    }
}
