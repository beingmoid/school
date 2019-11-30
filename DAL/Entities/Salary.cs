using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Salary: BaseEntity
    {
        public int StaffID { get; set; }
        public float BasicSalary { get; set; }
        public Staff Staff { get; set; }
    }
}
