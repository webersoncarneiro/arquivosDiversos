
using System;
using System.Globalization;

namespace Course {
    class Program {

        static void Main (string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos foram alugados  :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel : ");
                Console.WriteLine("Nome : ");
                string Nome = Console.ReadLine();
                Console.WriteLine("Email : ");
                string Email = Console.ReadLine();
                Console.WriteLine("Quarto :");
                int Quarto = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados :");
            for (int i = 0; i < 10; i++) {
                if (vect != null; < 10; i++){
                Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }  
    }
}


