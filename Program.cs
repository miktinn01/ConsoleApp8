using System;
using System.Collections.Generic;

namespace ConsoleApp8
{

    class Program
    {
        static void Main(string[] args)     //
        {
            var Book1 = new Book("Scotts grade book");
            Book1.AddGrade(89.1);
            Book1.AddGrade(90.5);
            Book1.AddGrade(77.5);

         var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
         grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)       // do this for every number in the array
                {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
                }
            result /= grades.Count;
            Console.WriteLine($"\nThe lowest grade is {lowGrade:N2}");
            Console.WriteLine($"\nThe highest grade is {highGrade:N2}");
            Console.WriteLine($"\nThe average grade is {result:N2}");
        }
        private static void DoAdd(string input)
        {
            throw new NotImplementedException();
        }
    }
}