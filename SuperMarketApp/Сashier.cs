using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class cashier:Staff
    {
        public cashier(double Salary, string Schedule,string Name):base(Salary,Schedule,Name)
        {
                
        }
        public override void Work()
        {
            Console.WriteLine($"Cashier {_Name} performs the reception, storage and accounting of cash.");
        }
    }
}
