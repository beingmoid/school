﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Test :BaseEntity
    {
        public decimal Marks { get; set; }
        public decimal Total { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
