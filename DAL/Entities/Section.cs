using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public  class Section:BaseEntity
    {
        public string Name { get; set; }
        public Grade Grade { get; set; }
        public int Gradeid { get; set; }
    }
}
