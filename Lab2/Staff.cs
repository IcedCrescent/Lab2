using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double RateSalary { get; set; }
        public double BasicSalary { get; set; }

        public Staff()
        {

        }

        public Staff(int iD, string name, int age, double rateSalary, double basicSalary)
        {
            ID = iD;
            Name = name;
            Age = age;
            RateSalary = rateSalary;
            BasicSalary = basicSalary;
        }

        public virtual double CalculateSalary()
        {
            return (double)RateSalary * BasicSalary;
        }

        public virtual double CalculateSalary(int allowance)
        {
            return RateSalary * BasicSalary + (double)(RateSalary * BasicSalary * allowance) / 100;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Total Salary: {0}", CalculateSalary());
        }
    }
}
