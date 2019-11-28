using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Staff:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public DateTime DOB { get; set; }

        public int Age { get; set; }
        public DateTime HiringDate { get; set; }
        public StaffType StaffType { get; set; }
        public int StaffTypeId { get; set; }


    }
}
