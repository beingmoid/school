using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ClassRooms:BaseEntity
    {
        public int Room { get; set; }
        public int Capacity { get; set; }
    }
}
