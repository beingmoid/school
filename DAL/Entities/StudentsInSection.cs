using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StudentsInSection:BaseEntity
    {
        public int SectionID { get; set; }
        public int StudentID { get; set; }
        public Section Section { get; set; }
        public Student Student { get; set; }
    }
}
