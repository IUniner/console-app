﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.PL.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}