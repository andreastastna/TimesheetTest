using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetTest
{
    public class Period
    { 
        public int PeriodID { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

        public ICollection<TimeUnit> TimeUnits { get; set; }
    }
}
