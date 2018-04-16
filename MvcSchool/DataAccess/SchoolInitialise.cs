using MvcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSchool.DataAccess
{
    public class SchoolInitialise : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //
            var students = new List<Student>
            {
                new Student{Surname="Packer",FirstName="Louise",Age=19,GPA=float.Parse("3.0")},
                new Student{Surname="Packer",FirstName="John",Age=21,GPA=float.Parse("2.5")},
                new Student{Surname="Looker",FirstName="Joan",Age=18,GPA=float.Parse("2.9")},
                new Student{Surname="Smith",FirstName="Gale",Age=19,GPA=float.Parse("2.8")},
                new Student{Surname="Johnson",FirstName="Peter",Age=18,GPA=float.Parse("2.0")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            //
            var classes = new List<Class>
            {
                new Class{ID=101,Name="UI/UX",TeacherName="Mr Johnston",Location="Building 5 Room 501"},
                new Class{ID=102,Name="DevOps",TeacherName="Mrs Thompson",Location="Building 2 Room 606"}
            };
            classes.ForEach(s => context.Classes.Add(s));
            context.SaveChanges();

            //
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,ClassID=101},                
                new Enrollment{StudentID=2,ClassID=102},
                new Enrollment{StudentID=3,ClassID=101},
                new Enrollment{StudentID=3,ClassID=102},
                new Enrollment{StudentID=4,ClassID=101},
                new Enrollment{StudentID=4,ClassID=102},
                new Enrollment{StudentID=5,ClassID=101}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
