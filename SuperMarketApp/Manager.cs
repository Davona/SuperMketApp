using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class Manager:Staff
    {
        public Manager(double Salary,string Schedule, String Name):base(Salary,Schedule, Name)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"the manager {_Name} monitors the work of employees");
        }
    }
}
