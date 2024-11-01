using System;
using System.Globalization;
using System.Collections.Generic;

namespace Company {
    class Program {
        static void Main(string[] args) {
            string name;
            double salary;
            int id;
            List<Employee> employees = new List<Employee>();


            Console.Write("How many employees will be registered?: ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amount; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (employees.Any(x => x.Id == id)) {
                    Console.WriteLine("Employee IDs must be different.");
                }
                else {
                    employees.Add(new Employee(id, name, salary));
                }

            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee empId = employees.Find(x => x.Id == searchId);
            if (empId != null) {
                Console.Write("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empId.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees) {
                Console.WriteLine(obj);
            }
        }
    }
}

