using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StudentLeaves:BaseEntity
    {
        public int StudentID { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int Days { get; set; }
        public string Reason { get; set; }
        public Student Student { get; set; }
    }
}
