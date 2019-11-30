using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StaffSalary: BaseEntity
    {
        public int StaffID { get; set; }
        public decimal Salary { get; set; }
        public int LeaveCount { get; set; }
        public int Overtime { get; set; }
        public DateTime? Month{ get; set; }
        public string BankAccount { get; set; }
        public Staff Staff { get; set; }
    }
}
