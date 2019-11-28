using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Page:BaseEntity
    {
        public Page()
        {
            this.UserRoles = new HashSet<UserRoles>();

        }
        public string Name { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
