using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Section : BaseEntity
    {
        public Section()
        {
            this.StudentsInSection = new HashSet<StudentsInSection>();
        }
        public string SectionName { get; set; }
        public int GradeID { get; set; }
        public Grade Grade { get; set; }
        
        public ICollection<StudentsInSection> StudentsInSection { get; set; }


    }
}
