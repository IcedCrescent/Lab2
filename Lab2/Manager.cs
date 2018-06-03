using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    public class Manager : Staff
    {
        public int NumberBusinessDay { get; set; }
        public double MoneyIncreased { get; set; }

        public Manager()
        {

        }

        public Manager(int id, string name, int age, double rateSalary, double basicSalary, int numberBusinessDay, double moneyIncreased) : base(id, name, age, rateSalary, basicSalary)
        {
            NumberBusinessDay = numberBusinessDay;
            MoneyIncreased = moneyIncreased;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() - (double) NumberBusinessDay * MoneyIncreased;
        }

        public override double CalculateSalary(int allowance)
        {
            return base.CalculateSalary(allowance) + NumberBusinessDay * MoneyIncreased;
        }
    }
}
