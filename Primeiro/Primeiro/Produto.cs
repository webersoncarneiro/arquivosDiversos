using System;
using System.Globalization;

namespace Course{
    class Produto {
        
        static void Main(string [] args){

            static double Pi = 3.14;

            Console.Write("Entre o valor do raio : ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Cincunferencia(raio);

            Console.WriteLine(Console.ReadLine("F2", CultureInfo.InvariantCulture));
        }

        static double Cincunferencia(double r){
            return 2.0 * Pi * r;
        }

    }
}
