using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class ShopAssistant:Staff
    {
        public ShopAssistant(double Salary,string Schedule,string Name):base(Salary,Schedule,Name)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"ShopAssistant {_Name} recommends to the buyer which product is better to buy, answers questions, helps to make the right decision");
        }
    }
}
