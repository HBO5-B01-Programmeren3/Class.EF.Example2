using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class.EF.Example2.Entities;

namespace Class.EF.Example2.Models
{
    public class HomeIndexVm
    {
        public Teacher TeacherWithIdOne { get; set; }

        public IEnumerable<Student> StudentsBornBefore2k { get; set; }

        public decimal TotalScholarships { get; set; }

        public IEnumerable<Student> ScholarShipStudentsWithInfo { get; set; }

        public IEnumerable<Course> Courses { get; set; }

    }
}
