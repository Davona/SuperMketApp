using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
      abstract class Staff
    {
        public Staff(double Salary, string Schedule, String Name)
        {
            _Salary = Salary;
            _Schedule = Schedule;
            _Name=Name;

        }
        private double _salary;

        public double _Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        private string _schedule;

        public string _Schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }
        public String _Name;

        public abstract void Work();
        
    }
}
