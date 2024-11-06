using System;

namespace Array2D {
    class Program {
        static void Main(string[] args) {

            int l, c;

            Console.Write("Enter the row and column of array2D: ");
            string[] arraysize = Console.ReadLine().Split(' ');
            l = int.Parse(arraysize[0]);
            c = int.Parse(arraysize[1]);

            int[,] array2D = new int[l, c];
            Console.WriteLine("Enter the values: ");

            for (int i = 0; i < l; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++) {
                    array2D[i, j] = int.Parse(values[j]);

                }
            }

            Console.WriteLine();
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; ++i) {
                for (int j = 0; j < c; ++j) {
                    if (array2D[i, j] == number) {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j > 0) {
                            Console.WriteLine($"Left: {array2D[i, j - 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {array2D[i - 1, j]}");
                        }
                        if (j < c - 1) {
                            Console.WriteLine($"Right: {array2D[i, j + 1]}");
                        }
                        if (i < l - 1) {
                            Console.WriteLine($"Down: {array2D[i + 1, j]}");
                        }
                    }
                }

            }
        }
    }
}