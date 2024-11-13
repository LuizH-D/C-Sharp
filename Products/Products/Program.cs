using System;
using System.Globalization;
using System.Collections.Generic;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quantity;)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported(c / u / i) ?: ");
                char prodType = char.Parse(Console.ReadLine());
                switch (prodType)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string prodName = Console.ReadLine();
                        Console.Write("Price: ");
                        double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new Product(prodName, prodPrice));
                        i++;
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        prodName = Console.ReadLine();
                        Console.Write("Price: ");
                        prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(prodName, prodPrice, date));
                        i++;
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        prodName = Console.ReadLine();
                        Console.Write("Price: ");
                        prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(prodName, prodPrice, fee));
                        i++;
                        break;
                    default:
                        Console.WriteLine("Enter only the product type (c / u / i)");
                        break;
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}