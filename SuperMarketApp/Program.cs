using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff Manager = new Manager(150000, "09:00-18:00", "Ashot");
            Staff shopAssistant = new ShopAssistant(100000, "09:00-18:00","Karen");
            Staff cleaner = new cleaner(80000, "08:00-17:00", "Anush");
            Staff cashier = new cashier(120000, "09:00-18:00", "Mher");
            List<Staff> staff = new List<Staff>();
            staff.Add(Manager);
            staff.Add(shopAssistant);
            staff.Add(cleaner);
            staff.Add(cashier);
            for (int i = 0; i < staff.Count; i++)
            {
                staff[i].Work();
            }
            
            

        }
    }
}
