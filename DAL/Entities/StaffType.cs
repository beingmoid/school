using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class StaffType:BaseEntity
    {
        public StaffType()
        {
            this.Staff = new HashSet<Staff>();
        }
        public string StaffTypeName { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
