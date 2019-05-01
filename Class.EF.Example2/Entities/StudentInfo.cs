using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class.EF.Example2.Entities
{
    public class StudentInfo
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Student Student { get; set; }
    }
}
