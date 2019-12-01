using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
     public class Student:BaseEntity
    {
        public Student()
        {
            this.Test = new HashSet<Test>();
            this.fees = new HashSet<Fees>();
            this.Homework = new HashSet<Homework>();
            this.StudentInSection = new HashSet<StudentInSection>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime AddmissionDate { get; set; }
        public ICollection<Test> Test { get; set; }
        public ICollection<Fees> fees { get; set; }
        public ICollection<Homework> Homework { get; set; }
        public ICollection<StudentInSection> StudentInSection { get; set; }


    }
}
