using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcSchool.Models
{
    public class Student
    {        
        public int ID { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public float GPA { get; set; }
        public bool IsHighGPA
        {
            get
            {
                return GPA >= 3.2;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }        
    }
}