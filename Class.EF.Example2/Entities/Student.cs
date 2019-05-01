using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class.EF.Example2.Entities
{
    public class Student
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public decimal? Scholarship { get; set; }

        public StudentInfo ContactInfo { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
