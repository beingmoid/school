using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
     public class Grade:BaseEntity
    {
        public Grade()
        {
            this.Section = new HashSet<Section>();
        }
        public string GradeName { get; set; }
        public string Class { get; set; }
        public ICollection<Section> Section { get; set; }
    }
}
