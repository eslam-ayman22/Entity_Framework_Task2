using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Student_System;Integrated Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         /*******students Table**********************/
            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber)
                .HasColumnType("varchar(10)");

           
                
                
            

            /********* Course table**********************/

            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .HasMaxLength(80);

            
                

            /**********Resource table***********************/

            modelBuilder.Entity<Resource>()
                .Property(e => e.Name)
                .HasMaxLength(50);

            /************************Relations****************/


            modelBuilder.Entity<Student>()
                .HasMany(e => e.HomeworkSubmissions)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
               .HasMany(e => e.HomeworkSubmissions)
               .WithOne(e => e.Course)
               .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
               .HasMany(e => e.StudentCourses)
               .WithOne(e => e.Course)
               .HasForeignKey(e => e.CourseId);



            /**************Add Data To student************************/
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                StudentId = 1,
                Name = "Eslam",
                Birthday = 2001,
                PhoneNumber = 01149043904,
                RegisteredOn = new DateTime(2015, 11, 06)
            });
            students.Add(new Student
            {
                StudentId = 2,
                Name = "Ali",
                Birthday = 2000,
                PhoneNumber = 0114908874,
                RegisteredOn = new DateTime(2023, 5, 08)
            });
            students.Add(new Student
            {
                StudentId = 3,
                Name = "Mahmoud",
                Birthday = 2003,
                PhoneNumber = 01028867657,
                RegisteredOn = new DateTime(2024, 10, 07)
            });
            students.Add(new Student
            {
                StudentId = 4,
                Name = "Karem",
                Birthday = 2004,
                PhoneNumber = 01025469875,
                RegisteredOn = new DateTime(2021, 11, 12)
            });
            students.Add(new Student
            {
                StudentId = 5,
                Name = "yousef",
                Birthday = 2005,
                PhoneNumber = 01097057214,
                RegisteredOn = new DateTime(2014, 11, 06)
            });
            modelBuilder.Entity<Student>().HasData(students);

            /////****************Add Data to Course table****************/

            List<Course> courses = new List<Course>();
            courses.Add(new Course
            {
                CourseId = 1,
                Description = "course 1",
                Endtime = new DateTime(2025, 5, 20),
                Name = "Javascript",
                Price = 5000,
                StartDate = new DateTime(2024, 5, 20)
            });
            courses.Add(new Course
            {
                CourseId = 2,
                Description = "course 2",
                Endtime = new DateTime(2025, 1, 30),
                Name = "Puthon",
                Price = 4500,
                StartDate = new DateTime(2024, 9, 20)
            });
            courses.Add(new Course
            {
                CourseId = 3,
                Description = "course 3",
                Endtime = new DateTime(2024, 12, 1),
                Name = "C++",
                Price = 6500,
                StartDate = new DateTime(2024, 1, 20)
            });
            modelBuilder.Entity<Course>().HasData(courses);
            /////*****************Add data to Resource***********************/

            List<Resource> resources = new List<Resource>();
            resources.Add(new Resource
            {
                ResourceId = 1,
                Name = "EF#111",
                ResourceType = ResourceType.Video,
                Url = "http//:www.Per.com",
                CourseId = 1
            });
            resources.Add(new Resource
            {
                ResourceId = 2,
                Name = "EA@112",
                ResourceType = ResourceType.Presentation,
                Url = "http//:www.Per.com",
                CourseId = 2
            });
            resources.Add(new Resource
            {
                ResourceId = 3,
                Name = "EQ2333",
                ResourceType = ResourceType.Docment_or_other,
                Url = "http//:www.EQ.com",
                CourseId = 3
            });
            modelBuilder.Entity<Resource>().HasData(resources);

            ///******************add data to HomeworkSubmission***********/
            List<HomeworkSubmission> homeworkSubmissions = new List<HomeworkSubmission>();
            homeworkSubmissions.Add(new HomeworkSubmission
            {
                HomeworkSubmissionId = 1,
                ContentType = ContentType.Application,
                SubmissionTime = 10,

                CourseId = 1,
                StudentId = 2

            });
            homeworkSubmissions.Add(new HomeworkSubmission
            {
                HomeworkSubmissionId = 2,
                ContentType = ContentType.Pdf,
                SubmissionTime = 15,

                StudentId = 2,
                CourseId = 3

            });
            homeworkSubmissions.Add(new HomeworkSubmission
            {
                HomeworkSubmissionId = 3,
                ContentType = ContentType.Zip,
                SubmissionTime = 20,

                StudentId = 4,
                CourseId = 1

            });
            modelBuilder.Entity<HomeworkSubmission>().HasData(homeworkSubmissions);

            ///**************add data to student_course********************/
            List<StudentCourse> studentCourses = new List<StudentCourse>();
            studentCourses.Add(new StudentCourse
            {

                CourseId = 2,
                StudentId = 2,
                StudentCourseId = 1

            });
            studentCourses.Add(new StudentCourse
            {

                CourseId = 3,
                StudentId = 4,
                StudentCourseId = 2
            });
            studentCourses.Add(new StudentCourse
            {

                CourseId = 1,
                StudentId = 1,
                StudentCourseId = 3
            });
            modelBuilder.Entity<StudentCourse>().HasData(studentCourses);

        }
        public void seedData()
        {
            
        }
    }
}
