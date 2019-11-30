using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Staff:BaseEntity
    {
        public Staff()
        {
            this.TeacherCourse = new HashSet<TeacherCourse>();
            this.StaffLeaves = new HashSet<StaffLeaves>();
            this.Salary = new HashSet<Salary>();
            this.StaffSalary = new HashSet<StaffSalary>();

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public DateTime DOB { get; set; }

        public int Age { get; set; }
        public DateTime HiringDate { get; set; }
        public StaffType StaffType { get; set; }
        public int StaffTypeId { get; set; }

        public ICollection<TeacherCourse> TeacherCourse { get; set; }
        public ICollection<StaffLeaves> StaffLeaves { get; set; }
        public ICollection<Salary> Salary{ get; set; }
        public ICollection<StaffSalary> StaffSalary { get; set; }


    }
}
