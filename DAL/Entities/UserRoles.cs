using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
     public class UserRoles:BaseEntity
    {
        public bool IsRead { get; set; }
        public bool IsAdd { get; set; }
        public bool IsDelete { get; set; }
        public bool Edit { get; set; }
       
        public int UserId { get; set; }
        public int PageID { get; set; }
        public Page Page { get; set; }
        public User User { get; set; }




    }
}
