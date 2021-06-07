using System;
using System.Collections.Generic;

// test change 15:09 7 jun
namespace ConsoleApp8
{
    class Book
    {
        // DT put (class level) variable declarations at the top, so that when you look at a class, you can straight away see what they are, rather than having them hidden away in the code.
        // DT Put blank line between methods, makes it a little less cluttered - also between different things in methods - see what I did in the CalcStats method? It's called whitespace
        // and use of whitespace does make things more readable.  They are particularly fussy where I am now, and that is fine.

        private List<double> grades;
        private string name;    // creates a private field name

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
            var aveOfGrades = 0.0;
            var highGrade = double.MinValue;        //inicialize variable to the smallest value possible
            var lowGrade = double.MaxValue;         //inicialize variable to the highest value possible
            var sumOfGrades = 0.00;

            foreach (var grade in grades)       // do this for every number in the array
            {
                highGrade = Math.Max(grade, highGrade);        //returns the highest of the 2 numbers
                lowGrade = Math.Min(grade, lowGrade);          //returns the lowest of the 2 numbers
                sumOfGrades += grade;
            }

            aveOfGrades = sumOfGrades/grades.Count; // DT I'd call this ave or avg or average - call it what it is.  Is part of something called 'Clean Coding' (started by 'Uncle Bob') for when you bored and feel like googling.
            // I've never seen /= before.  Pro move :)

            Console.WriteLine($"\nStatistics for {name}");
            Console.WriteLine($"\nThe lowest grade is {lowGrade}");
            Console.WriteLine($"\nThe highest grade is {highGrade}");
            Console.WriteLine($"\nThe average grade is {aveOfGrades:N2}");
        }
    }
}