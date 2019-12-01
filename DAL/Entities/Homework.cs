using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Homework:BaseEntity
    {
        public int Total { get; set; }
        public int marks { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
