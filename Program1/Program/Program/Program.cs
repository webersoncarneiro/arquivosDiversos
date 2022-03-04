using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            double n1, n2;


            Console.WriteLine("Entre com o primeiro número : ");
            n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o segundo número : ");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado;

            resultado = n1 + n2;
            Console.WriteLine("Soma " + resultado);

            resultado = n1 - n2;
            Console.WriteLine("Subtração " + resultado);

            resultado = n1 / n2;
            Console.WriteLine("Divisão " + resultado);

            resultado = n1 * n2;
            Console.WriteLine("Multiplicação " +  resultado);
          
        }
    }
}
