using MvcSchool.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSchool.Models
{
    public static class EnrollmentExtension
    {
        private static SchoolContext db = new SchoolContext();
        
        public static IEnumerable<Student> GetEligibleStudentForCourse(this IEnumerable<Student> list, int classid)
        {
            var studentsInClass = db.Enrollments.Where(i => i.ClassID == classid).ToList();

            if (studentsInClass != null)
                return list.Where(i => !studentsInClass.Any(j => j.Student.Surname == i.Surname));
                
            return null;
        }
    }
}