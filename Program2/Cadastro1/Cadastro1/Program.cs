using System;
using System.Globalization;


namespace Cadastro1{
    class Program{
        static void Main(string[] args) {

            Clientes cliente;
            

            Console.Write("Entre com o nome do cliente :");
            string nome = Console.ReadLine();
            Console.Write("Entre com o email do cliente :");
            string email = Console.ReadLine();
            Console.Write("Entre com o endereço do cliente :");
            string endereco = Console.ReadLine();
            Console.Write("Entre com o telefone do cliente :");
            int telefone = int.Parse(Console.ReadLine());

            Console.Write("Cliente já possui debitos anteriores : s/n");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S'){
                Console.Write("Digite o valor do debito anterior : ");
                double DebitoAnterior = double.Parse(Console.ReadLine());
                cliente = new Clientes(nome, email, endereco, telefone, DebitoAnterior);
            }
            else {

                cliente = new Clientes(nome, email, endereco, telefone); 
            
            }

            Console.WriteLine();
            Console.WriteLine("Dados do cliente atualizados :");
            Console.WriteLine(cliente);

            Console.WriteLine("Entre com o valor que irá pagar : ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Pagar(valor);
            Console.WriteLine("Dados da conta atualizados :");
            Console.WriteLine(cliente);
            
           
            
        }
    }

}
