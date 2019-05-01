using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class.EF.Example2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Class.EF.Example2.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                        .ToTable("StudentCourses")
                        .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                        .HasOne(sc => sc.Student)
                        .WithMany(s => s.StudentCourses)
                        .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                        .HasOne(sc => sc.Course)
                        .WithMany(s => s.StudentCourses)
                        .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<StudentInfo>()
                        .HasKey(si => si.Id); 

            modelBuilder.Entity<StudentInfo>()
                        .Property(si => si.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<StudentInfo>()
                        .Property(si => si.Email)
                        .HasMaxLength(100)
                        .IsRequired(); 
            
            modelBuilder.Entity<StudentInfo>()
                        .Property(si => si.Phone)
                        .HasMaxLength(30);

            modelBuilder.Entity<StudentInfo>()
                        .HasOne(si => si.Student)
                        .WithOne(s => s.ContactInfo)
                        .HasForeignKey<StudentInfo>(si => si.StudentId);

            modelBuilder.Entity<Course>()
                        .HasOne(c => c.Lecturer)
                        .WithMany(t => t.Courses)
                        .IsRequired(false)
                        .OnDelete(DeleteBehavior.ClientSetNull);

            DataSeeder.Seed(modelBuilder);
                        
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentInfo> StudentInfo { get; set; }
    }
}
