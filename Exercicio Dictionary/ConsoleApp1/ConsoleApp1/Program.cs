using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computer", Tier = 3 };
            Category c3 = new Category() { Id = 3, Name = "Smartphone", Tier = 3 };

            List<Product> products = new List<Product>()
            {
                new Product() {Id = 4, Name = "TV" , Price = 1000.0, Category = c1},
                new Product() {Id = 5, Name = "Computer" , Price = 700, Category = c2},
                new Product() {Id = 6, Name = "Sofá" , Price = 1000.0, Category = c3},
                new Product() {Id = 7, Name = "TV" , Price = 600.0, Category = c3},
                new Product() {Id = 8, Name = "Celular" ,  Price = 825.0, Category = c2},
                new Product() {Id = 9, Name = "Saw" , Price = 450.0, Category = c3},
                new Product() {Id = 10, Name = "Camera" , Price = 250.0, Category = c2},
                new Product() {Id = 11, Name = "Printer" , Price = 956.0, Category = c3},
                new Product() {Id = 12, Name = "Macbook" , Price = 860.0, Category = c2},
                new Product() {Id = 13, Name = "SoundBar" , Price = 1000.0, Category = c3}

            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900: ", r1);
        }
    }
}
