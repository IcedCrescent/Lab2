using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseLib
{
    class Program
    {
        static List<OfficeStaff> officeStaffList;
        static List<Manager> managerList;
        static void Main(string[] args)
        {
            officeStaffList = new List<OfficeStaff>();
            managerList = new List<Manager>();
            InputOfficeStaff(3);
            InputManager(3);
            foreach (OfficeStaff os in officeStaffList)
            {
                os.ShowInfo();
            }
            foreach (Manager manager in managerList)
            {
                manager.ShowInfo();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void InputOfficeStaff(int number) 
        {
            int count = 0;
            Console.WriteLine("INPUT {0} OFFICE STAFF", number);
            while (count < number)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter basic salary: ");
                    double basicSalary = double.Parse(Console.ReadLine());
                    Console.Write("Enter salary rate: ");
                    double rateSalary = double.Parse(Console.ReadLine());
                    Console.Write("Enter the number of non-working day: ");
                    int numNonWorkingDay = int.Parse(Console.ReadLine());
                    Console.Write("Enter the decrease amount: ");
                    double moneyDecrease = double.Parse(Console.ReadLine());
                    OfficeStaff officeStaff = new OfficeStaff(id, name, age, rateSalary, basicSalary, numNonWorkingDay, moneyDecrease);
                    officeStaffList.Add(officeStaff);
                    count++;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("An exception is thrown, likely because of your input");
                    Console.WriteLine(e.Message);
                    continue;
                }
                
            }
        }

        static void InputManager(int number)
        {
            int count = 0;
            Console.WriteLine("INPUT {0} MANAGER", number);
            while (count < number)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter basic salary: ");
                    double basicSalary = double.Parse(Console.ReadLine());
                    Console.Write("Enter salary rate: ");
                    double rateSalary = double.Parse(Console.ReadLine());
                    Console.Write("Enter the number of business day: ");
                    int numBusinessDay = int.Parse(Console.ReadLine());
                    Console.Write("Enter the money increase: ");
                    double moneyIncrease = double.Parse(Console.ReadLine());
                    Manager manager = new Manager(id, name, age, rateSalary, basicSalary, numBusinessDay, moneyIncrease);
                    managerList.Add(manager);
                    count++;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("An exception is thrown, likely because of your input");
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }


}
