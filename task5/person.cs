using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
     class Person
    {
        public Person(string name, int age, string adress, string nationallity)
        {
            Name = name;
            Age = age;
            Adress = adress;
            Nationallity = nationallity;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Nationallity { get; set; }

    }
}
