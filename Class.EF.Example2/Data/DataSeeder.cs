using Class.EF.Example2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Class.EF.Example2.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region Seeding Zonder Relaties

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "Mr. Ned Farious", YearlyWage = 27150 },
                new Teacher { Id = 2, Name = "Mrs. Alley Hope", YearlyWage = 31520 });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Marty Pants", Scholarship = null, Birthdate = DateTime.ParseExact("10/05/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture), },
                new Student { Id = 2, Name = "Chris Mahs", Scholarship = 1200, Birthdate = DateTime.ParseExact("25/12/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture), },
                new Student { Id = 3, Name = "Ann A. Fabettick", Scholarship = 600, Birthdate = DateTime.ParseExact("15/08/1997", "dd/MM/yyyy", CultureInfo.InvariantCulture), },
                new Student { Id = 4, Name = "Will Szeedt", Scholarship = null, Birthdate = DateTime.ParseExact("26/02/1999", "dd/MM/yyyy", CultureInfo.InvariantCulture), });

            #endregion

            #region Seeding en foreign keys

            modelBuilder.Entity<StudentInfo>().HasData(
                new StudentInfo
                {
                    Id = 100,
                    StudentId = 1,
                    Email = "martypants@school.example",
                    Phone = null,
                },
                new StudentInfo
                {
                    Id = 101,
                    StudentId = 2,  
                    Email = "chrismahs@school.example",
                    Phone = "111 11 11 11",
                },
                new StudentInfo
                {
                    Id = 102,
                    StudentId = 3,  
                    Email = "annaf@school.example",
                    Phone = "222 22 22 22",
                },
                new StudentInfo
                {
                    Id = 103,
                    StudentId = 4,    
                    Email = "willszeedt@school.example",
                    Phone = null,
                });

            modelBuilder.Entity<Course>().HasData(
                new
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Programming C#",
                    LecturerId = (long?)1     
                },
                new
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Elementary Database Design",
                    LecturerId = (long?)2   
                },
                new
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "ASP.NET Core",
                    LecturerId = (long?)1   
                });

            #endregion
        }
    }
}
