using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetTest
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }

        public Project Project { get; set; }
        public ICollection<TimeUnit> TimeUnits { get; set; }
    }
}
