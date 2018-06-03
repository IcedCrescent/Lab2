using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    public class OfficeStaff : Staff
    {
        public int NumberNonWorkingDay {get; set;}
        public double MoneyDecrease { get; set; }
        
        public  OfficeStaff()
        {

        }

        public OfficeStaff(int id, string name, int age, double rateSalary, double basicSalary, int numberNonWorkingDay, double moneyDecrease) : base(id, name, age, rateSalary, basicSalary)
        {
            NumberNonWorkingDay = numberNonWorkingDay;
            MoneyDecrease = moneyDecrease;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() - (double)NumberNonWorkingDay * MoneyDecrease;
        }

        public override double CalculateSalary(int allowance)
        {
            return base.CalculateSalary(allowance) - (double) NumberNonWorkingDay * MoneyDecrease;
        }
    }
}
