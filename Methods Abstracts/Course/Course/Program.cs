using System;
using Course.Entities.Enum;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)? ");
                char format = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (format == 'r')
                {
                    Console.Write("Width :");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height :");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius :");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS :");
                foreach ( Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
