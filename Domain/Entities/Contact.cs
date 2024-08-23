﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
    }
}
