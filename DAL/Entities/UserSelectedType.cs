﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserSelectedType:BaseEntity
    {
        public User User { get; set; }
        public UserType UserType { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
    }
}
