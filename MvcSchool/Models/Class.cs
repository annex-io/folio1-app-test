using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcSchool.Models
{
    public class Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string TeacherName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}