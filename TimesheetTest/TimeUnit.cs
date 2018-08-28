using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetTest
{
    public class TimeUnit
    {
        public int TimeUnitID { get; set; }
        public string TimeUnitName { get; set; }
        public string TimeUnitCode { get; set; }

        public Task Task { get; set; }
        public Period Period { get; set; }
    }
}
