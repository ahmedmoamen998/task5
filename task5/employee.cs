using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
     class Employee : Person
    {
        public Employee(string name, int age, string adress, string nationallity,

            double salary, double rank, string jop) : base(name, age, adress, nationallity)
        {
            Salary = salary;
            Rank = rank;
            Jop = jop;
        }

        public double Salary { get; set; }
        public double Rank { get; set; }
        public string Jop { get; set; }


    }
}
