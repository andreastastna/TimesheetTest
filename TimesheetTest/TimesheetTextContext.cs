using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TimesheetTest
{
    public class TimesheetTextContext: DbContext
    {
        public TimesheetTextContext(): base()
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TimeUnit> TimeUnits { get; set; }
        public DbSet<Period> Periods { get; set; }

    }
}
