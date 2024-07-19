using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Description { get; set; }
        public DateTime Endtime { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
