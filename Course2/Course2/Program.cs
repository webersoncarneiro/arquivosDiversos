using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.WriteLine("Entre com o número da conta : ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular da conta : ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito ? s/n");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S'){
                Console.WriteLine("Entre com o depósito : ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular ,DepositoInicial);  
            }

            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados : ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o depósito : ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados : ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do saque : ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados : ");
            Console.WriteLine(conta);
  
        }
    }
}