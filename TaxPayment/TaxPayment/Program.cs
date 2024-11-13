using System;
using System.Globalization;
using System.Collections.Generic;
using TaxPayment.Entities;

namespace TaxPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numberOfTaxPayers;)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)?: ");
                char payerType = char.Parse(Console.ReadLine());
                switch (payerType)
                {
                    case 'i':
                        Console.Write("Name: ");
                        string payerName = Console.ReadLine();
                        Console.Write("Anual Income: ");
                        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        taxPayers.Add(new Individual(payerName, anualIncome, healthExpenditures));
                        i++;
                        break;
                    case 'c':
                        Console.Write("Name: ");
                        payerName = Console.ReadLine();
                        Console.Write("Anual Income: ");
                        anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Number of employees: ");
                        int employees = int.Parse(Console.ReadLine());
                        taxPayers.Add(new Company(payerName, anualIncome, employees));
                        i++;
                        break;
                    default:
                        Console.WriteLine("ENTER ONLY i/c");
                        break;
                }
                Console.WriteLine();
            }

            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer taxPayer in taxPayers)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer);
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}