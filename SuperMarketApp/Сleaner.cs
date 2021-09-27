using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class cleaner : Staff
    {
        public cleaner(double Salary, string Schedule, string Name) : base(Salary, Schedule, Name)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"Cleaner {_Name} engaged in cleaning the premises");
        }
    }
}
