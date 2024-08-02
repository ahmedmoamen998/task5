using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{

     class Hourly:Employee
    {
        public Hourly(string name, int age, string adress, string nationallity,

            double salary, double rank, string jop,
            double workedHour, double hourRate):base(name,age,adress,nationallity,salary,rank,jop)
        {
            WorkedHour = workedHour;
            HourRate = hourRate;
        }

        public double WorkedHour { get; set; }
        public double HourRate { get; set; }
    }
}
