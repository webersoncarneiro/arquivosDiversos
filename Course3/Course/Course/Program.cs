using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args) {

            
            Console.WriteLine("O bruce é gay s/n");

            char bruce = char.Parse(Console.ReadLine());
            if ( bruce == 's' || bruce == 'S' )
            {
                Console.WriteLine("Bruce é gay ");
            }
            else
            {
                Console.WriteLine("O bruce não é gay");
            }



        }
    }
}
