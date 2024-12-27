using System;
using PaymentProject.Entities;
using PaymentProject.Services;
using System.Globalization;

namespace PaymentProject {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int installments = int.Parse(Console.ReadLine());
                
                Contract contract = new Contract(number, date, value);

                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(contract, installments);

                Console.WriteLine("Installments:");
                foreach (Installment installment in contract.Installment) {
                    Console.WriteLine(installment);
                }
            }
            catch (FormatException ex){
                Console.WriteLine($"Format error: {ex.Message}");
            }
        }
    }
}

