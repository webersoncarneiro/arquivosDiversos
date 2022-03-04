using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;

            ContaBancaria conta;

            Console.WriteLine("Entre com o nome do cliente :");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o número da conta do cliente");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome do seu banco ? ");
            string banco = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial ? s/n");
            char conf = char.Parse(Console.ReadLine());

            try
            {

                if (conf == 's' || conf == 'S')
                {
                    Console.WriteLine("Entre com o valor do deposito inicial : ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(nome, numero, banco, depositoInicial);
                }
                else
                {
                    conta = new ContaBancaria(nome, numero, banco);
                }

                Console.WriteLine("Entre com o valor do depósito :");
                double deposito = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados atualizados : ");
                conta.Deposito(deposito);
                Console.WriteLine(conta);

                Console.WriteLine();

                Console.WriteLine("Entre com o valor de saque :");
                double saque = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados atualizados : ");
                conta.Saque(saque);
                Console.WriteLine(conta);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro : " + e.Message);
            }
        }
    }
}
