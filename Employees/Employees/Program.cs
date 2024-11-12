using System;
using System.Globalization;
using System.Collections.Generic;
using Employees.Entities;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int mount = int.Parse(Console.ReadLine());

            for (int i = 0; i < mount;)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)?: ");
                string outsourced = Console.ReadLine();
                switch (outsourced)
                {
                    case "y":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Employee outsrcEomployee = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                        employees.Insert(i,outsrcEomployee);
                        i++;
                        break;
                    case "n":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Hours: ");
                        hours = int.Parse(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, hours, valuePerHour));
                        i++;
                        break;
                     default:
                        Console.WriteLine("Enter only Y or N");  
                        break;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}