using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Produto p = new Produto(); 

            Console.WriteLine("Entre os dados do produto : ");
            Console.Write(" Nome : ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque : ");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque : ");

            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados :" + p);

        }
    }
}
