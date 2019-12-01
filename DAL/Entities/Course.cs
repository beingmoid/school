using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
  public  class Course:BaseEntity
    {
        public Course()
        {
            this.TeacherCourses = new HashSet<TeacherCourses>();
            this.Test = new HashSet<Test>();
            this.Homework = new HashSet<Homework>();
        }
        public string CourseName { get; set; }
        public ICollection<TeacherCourses> TeacherCourses { get; set; }
        public ICollection<Test> Test { get; set; }
        public ICollection<Homework> Homework { get; set; }
    }
}
