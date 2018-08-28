﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetTest
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}