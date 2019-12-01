using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
     public class TeacherCourses:BaseEntity
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Staff Staff { get; set; }
        public int StaffId { get; set; }
    }
}
