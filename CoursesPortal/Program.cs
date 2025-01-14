using System;
using CoursesPortal.Entities;
using System.Collections.Generic;

namespace CoursesPortal {
    class Program {
        static void Main(string[] args) {

            HashSet<Student> set = new HashSet<Student>();

            try {
                Console.Write("How many students for course Portuguese? ");
                int course1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 1; i <= course1; i++) {
                    Console.Write("Enter Student Registration: ");
                    int registration = int.Parse(Console.ReadLine());
                    set.Add(new Student(registration));
                }

                Console.WriteLine();
                Console.Write("How many students for course English? ");
                int course2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 1; i <= course2; i++) {
                    Console.Write("Enter Student Registration: ");
                    int registration = int.Parse(Console.ReadLine());
                    set.Add(new Student(registration));
                }

                Console.WriteLine();
                Console.Write("How many students for course Spanish? ");
                int course3 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 1; i <= course3; i++) {
                    Console.Write("Enter Student Registration: ");
                    int registration = int.Parse(Console.ReadLine());
                    set.Add(new Student(registration));
                }

                Console.WriteLine();
                Console.WriteLine($"Total students: {set.Count}");
            }
            catch (FormatException ex) {
                Console.WriteLine($"Format error: {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}