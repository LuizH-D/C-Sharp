using System;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {
            int n, num;
            string nome, email;
            Quarto[] quarto = new Quarto[10];

            for(int i = 0; i < 10; i++) {
                quarto[i] = new Quarto(i);
            }

            Console.Write("Quantos quartos serão alugados?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i >= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                num = int.Parse(Console.ReadLine());

                quarto[num].Vago = false;
                quarto[num].Hospede = new Cliente(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (quarto[i].Vago == false) {
                    Console.WriteLine($"{i}: {quarto[i].Hospede.ToString()}");
                }
            }
        }
    }
}