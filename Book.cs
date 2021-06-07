using System;
using System.Collections.Generic;

// test change 15:09 7 jun
namespace ConsoleApp8
{
    class Book
    {
        public Book(string name)       // requires a name when invoke constructor
        {
            grades = new List<double>();
            this.name = name;       // this is used when the field has the same name a parameter
        }
        // below creates the method AddGrade
        public void AddGrade(double grade)      //public is an access modifier, it controls access to the member of the class. 
        {
                grades.Add(grade);      
        }
        public void CalcStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue;        //inicialize variable to the smallest value possible
            var lowGrade = double.MaxValue;         //inicialize variable to the highest value possible
            foreach (var number in grades)       // do this for every number in the array
            {
                highGrade = Math.Max(number, highGrade);        //returns the highest of the 2 numbers
                lowGrade = Math.Min(number, lowGrade);          //returns the lowest of the 2 numbers
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"\nStatistics for {name}");
            Console.WriteLine($"\nThe lowest grade is {lowGrade}");
            Console.WriteLine($"\nThe highest grade is {highGrade}");
            Console.WriteLine($"\nThe average grade is {result:N2}");
        }

        private List<double> grades;
        private string name;    // creates a private field name
    }
}