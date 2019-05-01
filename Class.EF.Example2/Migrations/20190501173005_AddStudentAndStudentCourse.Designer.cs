﻿// <auto-generated />
using System;
using Class.EF.Example2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Class.EF.Example2.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20190501173005_AddStudentAndStudentCourse")]
    partial class AddStudentAndStudentCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Class.EF.Example2.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("LecturerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal?>("Scholarship");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.StudentCourse", b =>
                {
                    b.Property<long>("StudentId");

                    b.Property<Guid>("CourseId");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal?>("YearlyWage");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.Course", b =>
                {
                    b.HasOne("Class.EF.Example2.Entities.Teacher", "Lecturer")
                        .WithMany("Courses")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.StudentCourse", b =>
                {
                    b.HasOne("Class.EF.Example2.Entities.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Class.EF.Example2.Entities.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
