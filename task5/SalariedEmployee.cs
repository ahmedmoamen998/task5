using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class SalariedEmployee : Employee
    {
        public SalariedEmployee(double bonus, double deduction, string name, int age, string adress, string nationallity,

            double salary, double rank, string jop) :base (name,age,adress,nationallity,salary,rank,jop)
        {
            Bonus = bonus;
            Deduction = deduction;
        }

        public double Bonus { get; set; }
        public double Deduction{ get; set; }
    }
}
