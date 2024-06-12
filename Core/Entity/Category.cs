﻿using Core.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
