using System;
using Teste;

namespace MyApp
{
    /// <summary>
    /// Valor Adicional
    /// </summary>
   public class Program
    {
        static void Main(string[] args)
        {
            //int idade;
            double idade1 = 25.3;
            var idade = 25.3;
            int? idade5 = null;
            var salario = 2500;
            var salario1 = 2.500;
            float salario3 = 2.500f;
            decimal salarioAnual = 25.000m;
            double salarioSemestral = 22.000;
            bool temSalario = true;
            var usuarioExpirado = false;
            char usuario = 'A';
            var segundaLetra = 'B';
            string nome = "Weberson";
            object nome2 = null;

            //Conversão implícita - tipos de dados compatíveis
            float valor = 25.5f;
            int outro = 25;        
            valor = outro;

            // Conversão Explícita - quando é obrigado a declarar o tipo de dado convertido;
            int idade10 = 25;
            float idade11 = 25.7f;
            idade10 = Convert.ToInt32(idade11);

            // o Parse sempre espera uma string
            int inteiro = int.Parse("100");

            var texto = "Testando";
            Console.WriteLine(texto);
            Console.WriteLine(idade5);
        }
    }
}
