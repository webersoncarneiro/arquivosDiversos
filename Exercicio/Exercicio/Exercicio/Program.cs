using System;
using System.Globalization;

namespace Exercicio{
    class Program{
        static void Main(string[] args){

            Funcionario func = new Funcionario();

            Console.Write("Digite o nome do funcionário : ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto do funcionário: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual é o imposto cobrado em cima do salário  : ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario : " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em porcentagem ");

            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados : " + func);





        }
    }
}
