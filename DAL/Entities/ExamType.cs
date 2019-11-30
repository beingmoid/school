using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ExamType: BaseEntity
    {
        public ExamType()
        {
            this.Exams = new HashSet<Exams>();
        }
        public String ExamType_Name { get; set; }
        public ICollection<Exams> Exams{ get; set; }

    }
}
