using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class.EF.Example2.Data;
using Class.EF.Example2.Entities;
using Class.EF.Example2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Class.EF.Example2.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext schoolContext;

        public HomeController(SchoolContext context)
        {
            schoolContext = context;
        }

        public IActionResult Index()
        {
            var vm = new HomeIndexVm();

            long teachId = 10;
            vm.TeacherWithIdOne = schoolContext.Teachers.Find(teachId);

            vm.StudentsBornBefore2k = schoolContext.Students
                                                   .Where(s => s.Birthdate.Year < 2000)
                                                   .OrderBy(s => s.Name)
                                                   .ToList();
            vm.TotalScholarships = schoolContext.Students.Sum(s => s.Scholarship) ?? 0;

            vm.ScholarShipStudentsWithInfo = schoolContext.Students
                .Include(s => s.ContactInfo)
                .Where(s => s.Scholarship != null)
                .OrderByDescending(s => s.Scholarship)
                .ThenBy(s => s.Name)
                .ToList();

            var allStudentCourses = schoolContext.Set<StudentCourse>()
                .Include(sc => sc.Course)
                .ThenInclude(c => c.Lecturer)
                .Include(sc => sc.Student)
                .ThenInclude(s => s.ContactInfo).ToList();

            vm.Courses = allStudentCourses.Select(sc => sc.Course)
                .Distinct()
                .OrderByDescending(sc => sc.StudentCourses.Count);

            return View(vm);
        }
    }
}