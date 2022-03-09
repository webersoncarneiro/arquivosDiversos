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

            var product = new Product( 5, "Weberson", 50.0, Product.EProductType.Product );           

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Price);
            Console.WriteLine((int)product.Type);
        }

    }

    struct Product
    {

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public EProductType Type { get; set; }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }

       public enum EProductType
        {
            Product = 1,
            Service = 2

        }
    }
}
