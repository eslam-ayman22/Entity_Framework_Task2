using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class HomeworkSubmission
    {
        public int HomeworkSubmissionId { get; set; }
        public ContentType ContentType  { get; set; }
        public int SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
