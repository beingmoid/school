using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Exams: BaseEntity
    {
        public int ExamTypeID { get; set; }
        public ExamType ExamType { get; set; }
        public String  ExamName{ get; set; }
    }
}
