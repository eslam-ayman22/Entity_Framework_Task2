﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P01_StudentSystem.Data;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    [Migration("20240719175216_add_data_to_homeworkSubmissions_Table")]
    partial class add_data_to_homeworkSubmissions_Table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P01_StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Endtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "course 1",
                            Endtime = new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Javascript",
                            Price = 5000,
                            StartDate = new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "course 2",
                            Endtime = new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Puthon",
                            Price = 4500,
                            StartDate = new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CourseId = 3,
                            Description = "course 3",
                            Endtime = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "C++",
                            Price = 6500,
                            StartDate = new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.HomeworkSubmission", b =>
                {
                    b.Property<int>("HomeworkSubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkSubmissionId"));

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionTime")
                        .HasColumnType("int");

                    b.HasKey("HomeworkSubmissionId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("HomeworkSubmissions");

                    b.HasData(
                        new
                        {
                            HomeworkSubmissionId = 1,
                            ContentType = 0,
                            CourseId = 1,
                            StudentId = 2,
                            SubmissionTime = 10
                        },
                        new
                        {
                            HomeworkSubmissionId = 2,
                            ContentType = 1,
                            CourseId = 3,
                            StudentId = 2,
                            SubmissionTime = 15
                        },
                        new
                        {
                            HomeworkSubmissionId = 3,
                            ContentType = 2,
                            CourseId = 1,
                            StudentId = 4,
                            SubmissionTime = 20
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "EF#111",
                            ResourceType = 0,
                            Url = "http//:www.Per.com"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 2,
                            Name = "EA@112",
                            ResourceType = 1,
                            Url = "http//:www.Per.com"
                        },
                        new
                        {
                            ResourceId = 3,
                            CourseId = 3,
                            Name = "EQ2333",
                            ResourceType = 2,
                            Url = "http//:www.EQ.com"
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("Birthday")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = 2001,
                            Name = "Eslam",
                            PhoneNumber = "1149043904",
                            RegisteredOn = new DateTime(2015, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = 2000,
                            Name = "Ali",
                            PhoneNumber = "114908874",
                            RegisteredOn = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 3,
                            Birthday = 2003,
                            Name = "Mahmoud",
                            PhoneNumber = "1028867657",
                            RegisteredOn = new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 4,
                            Birthday = 2004,
                            Name = "Karem",
                            PhoneNumber = "1025469875",
                            RegisteredOn = new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 5,
                            Birthday = 2005,
                            Name = "yousef",
                            PhoneNumber = "1097057214",
                            RegisteredOn = new DateTime(2014, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentCourseId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.HomeworkSubmission", b =>
                {
                    b.HasOne("P01_StudentSystem.Models.Course", "Course")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P01_StudentSystem.Models.Student", "Student")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Resource", b =>
                {
                    b.HasOne("P01_StudentSystem.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("P01_StudentSystem.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P01_StudentSystem.Models.Student", "student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Course", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("Resources");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Student", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
