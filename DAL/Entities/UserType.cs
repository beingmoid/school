using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
  public  class UserType:BaseEntity
    {
        public UserType()
        {
            this.UserSelectedType = new HashSet<UserSelectedType>();

        }
        public string Name { get; set; }
        public ICollection<UserSelectedType> UserSelectedType { get; set; }
    }
}
