using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TeacherCourse: BaseEntity
    {
        public TeacherCourse()
        {
            this.CourseExam = new HashSet<CourseExam>();
        }
        public int CourseID { get; set; }
        public int StaffID { get; set; }
        public Course Course { get; set; }
        public Staff Staff { get; set; }
        public ICollection<CourseExam> CourseExam { get; set; }
    }
}
