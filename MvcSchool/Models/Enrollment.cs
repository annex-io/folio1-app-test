using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcSchool.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }

        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}