using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetTest
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new TimesheetTextContext())
            {
                var proj = new Project() { ProjectName = "test" };

                ctx.Projects.Add(proj);
                ctx.SaveChanges();
            }
        }
    }
}
