using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários serão registrados ? : ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário#" + i + ": ");
                Console.Write("Id : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome :");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário : ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o Id do funcionário que receberá o aumento : ");
            int QualId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == QualId);
            if (func != null){
                Console.WriteLine("Entre com a porcentagem de aumento :");
                double porcentagem = double.Parse(Console.ReadLine());
                func.AumentarSalario(porcentagem);

            }
            else{
                Console.WriteLine("Esse Id não existe : ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista com os valores atualizados :");
            foreach(Funcionario obj in list){
                Console.WriteLine(obj);
            }
        }



    }
}



