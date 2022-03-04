using System;
using System.Globalization;

namespace Exercicio1{
    class Program{
        static void Main(string[] args){

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno : ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a nota dos três alunos : ");
            Console.WriteLine();
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" NOTA FINAL = "
                 + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()){
                Console.WriteLine("REPROVADO");
            }
            else{
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " Pontos");
            }
        }
    }
}
