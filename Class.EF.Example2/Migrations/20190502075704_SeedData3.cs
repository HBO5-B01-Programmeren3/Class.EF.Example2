using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Class.EF.Example2.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "StudentId", "CourseId" },
                values: new object[,]
                {
                    { 1L, new Guid("11111111-1111-1111-1111-111111111111") },
                    { 1L, new Guid("33333333-3333-3333-3333-333333333333") },
                    { 2L, new Guid("11111111-1111-1111-1111-111111111111") },
                    { 2L, new Guid("22222222-2222-2222-2222-222222222222") },
                    { 2L, new Guid("33333333-3333-3333-3333-333333333333") },
                    { 4L, new Guid("22222222-2222-2222-2222-222222222222") },
                    { 4L, new Guid("33333333-3333-3333-3333-333333333333") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1L, new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1L, new Guid("33333333-3333-3333-3333-333333333333") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2L, new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2L, new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2L, new Guid("33333333-3333-3333-3333-333333333333") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 4L, new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 4L, new Guid("33333333-3333-3333-3333-333333333333") });
        }
    }
}
