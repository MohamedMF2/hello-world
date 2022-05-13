using System;
using System.Collections.Generic;
namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            // var numbers = new[] { 10.5, 15.4, 22.5, 20 };
            List<double> grades = new List<double>() { 10.5, 15.4, 22.5, 20 };
            // var gradesCount = grades.Count;
            // Console.WriteLine($"gradesCount = {gradesCount}");

            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;

            }

            result /= grades.Count;
            Console.WriteLine($"average Grade = {result:N3}");


            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !");

            }
            else
            {

                Console.WriteLine("Hello World!");
            }
        }
    }
}
