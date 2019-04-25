using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class.EF.Example2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Class.EF.Example2.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
