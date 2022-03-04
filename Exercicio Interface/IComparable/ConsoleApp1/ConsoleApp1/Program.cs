using System;
using ConsoleApp1.Entities;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\lindo.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(list);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
