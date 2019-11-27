﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            this.Sessions = new HashSet<Sessions>();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public bool Status { get; set; }

        public ICollection<Sessions> Sessions{ get; set; }

    }
}