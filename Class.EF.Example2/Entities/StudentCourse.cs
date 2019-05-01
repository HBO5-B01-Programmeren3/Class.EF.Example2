using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class.EF.Example2.Entities
{
    public class StudentCourse
    {
        public long StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
