using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
     public class Fees:BaseEntity
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Grade Grade { get; set; }
        public int GradeId { get; set; }
    }
}
