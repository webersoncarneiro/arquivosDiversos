﻿using System;
using Console2.Entities.Enums;
using Console2.Entities;
using System.Globalization;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's Name :");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter with worker date : ");
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Level (JUNIOR/MIDLEVEL/SENIOR: )");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary :");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contract to this worker ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour :");
                double ValuePorHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, ValuePorHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter with mouth and year to calculate income (MM/YYYY) : ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
