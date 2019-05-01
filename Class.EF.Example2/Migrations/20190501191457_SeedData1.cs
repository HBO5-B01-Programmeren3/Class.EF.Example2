using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Class.EF.Example2.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "Name", "Scholarship" },
                values: new object[,]
                {
                    { 1L, new DateTime(2001, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marty Pants", null },
                    { 2L, new DateTime(1998, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris Mahs", 1200m },
                    { 3L, new DateTime(1997, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ann A. Fabettick", 600m },
                    { 4L, new DateTime(1999, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Will Szeedt", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "YearlyWage" },
                values: new object[,]
                {
                    { 1L, "Mr. Ned Farious", 27150m },
                    { 2L, "Mrs. Alley Hope", 31520m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
