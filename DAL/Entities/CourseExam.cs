using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CourseExam:BaseEntity
    {
        public int TeacherCourseID { get; set; }
        public int Total { get; set; }
        public decimal Marks { get; set; }
        public TeacherCourse TeacherCourse { get; set; }


    }
}
