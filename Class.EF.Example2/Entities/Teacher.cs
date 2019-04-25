using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class.EF.Example2.Entities
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal YearlyWage { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
