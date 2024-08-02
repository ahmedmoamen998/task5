using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
     class Student:Person 
    {
        public Student(string name, int age, string adress,
            string nationallity, int studyLevel, double gpa,
            string specialization) : base(name, age, adress,nationallity)
        {
            StudyLevel = studyLevel;
            Gpa = gpa;
            Specialization = specialization;
        }

        public int StudyLevel { get; set; }
        public double Gpa { get; set; }
        public string Specialization { get; set; }

    }
}
