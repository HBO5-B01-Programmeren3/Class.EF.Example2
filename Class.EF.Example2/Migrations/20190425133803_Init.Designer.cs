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
    [Migration("20190425133803_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Class.EF.Example2.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("LecturerId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("YearlyWage");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Class.EF.Example2.Entities.Course", b =>
                {
                    b.HasOne("Class.EF.Example2.Entities.Teacher", "Lecturer")
                        .WithMany("Courses")
                        .HasForeignKey("LecturerId");
                });
#pragma warning restore 612, 618
        }
    }
}