using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("04/03/2021");
            DateTime d2 = DateTime.Parse("2021 - 04 - 03 16:14");

            DateTime d3 = DateTime.Parse("15/08/2000");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            TimeSpan t1 = TimeSpan.FromDays(1.5);

            Console.WriteLine(t1);



        }
    }
}
