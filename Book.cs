using System;
using System.Collections.Generic;

namespace GradeBook_v3
{
    public class Book
    {
        // DT put (class level) variable declarations at the top, so that when you look at a class, you can straight away see what they are, rather than having them hidden away in the code.
        // DT Put blank line between methods, makes it a little less cluttered - also between different things in methods - see what I did in the CalcStats method? It's called whitespace
        // DT use of whitespace does make things more readable.  They are particularly fussy where I am now, and that is fine.

        private List<double> grades;    // creates a private List of type double with name grades
        
        public Book(string name)       // requires a name when invoke constructor
        {
            grades = new List<double>(); // this code snippet creates a list of type double & total number of items it can hold is left open.
            Name = name;       // 
        }

        // DT need public property to test name
       public string Name { get; set; }              //{ get; set; } are referred as {{c1::property accessors}} and are auto - implemented properties
                                                     // by convention public members like Name (or public members, fields or other types) must have Uppercase N

        // below creates the method AddLetterGrade
        public void AddLetterGrade(char letter)      //
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);   // adds the grade in place of the letter to the method AddGrade
                    break;
                case 'B':
                    AddGrade(80);   // adds the grade in place of the letter to the method AddGrade
                    break;
                case 'C':
                    AddGrade(70);   // adds the grade in place of the letter to the method AddGrade
                    break;
                default:
                    AddGrade(0);   // adds the grade 0 in place of the any other letter the method AddGrade
                    break;
            }
        }

        // below creates the method AddGrade
        public void AddGrade(double grade)      //public is an access modifier, it controls access to the member of the class. 
        {
            if(grade <= 100 && grade >= 0 )
                {
                grades.Add(grade);
                }
            else
            {
                //Console.WriteLine("Invalid value for grade");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStats()    // this is a method
        {
            var result = new Statistics();      // creates new object 
            result.Average = 0.0;
            result.High = double.MinValue;        //inicialize variable to the smallest value possible
            result.Low = double.MaxValue;         //inicialize variable to the highest value possible
            //var sumOfGrades = 0.00;

           // foreach (var grade in grades)       // do this for every number in the array          previous loop style
           for ( var index = 0; index < grades.Count; index +=1 )
            {
                result.Low = Math.Min(grades[index], result.Low);      //returns the lowest of the 2 numbers
                result.High = Math.Max(grades[index], result.High);      //returns the highest of the 2 numbers
                result.Average+= grades[index];
            }
            result.Average /= grades.Count; // DT I'd call this ave or avg or average - call it what it is.  Is part of something called 'Clean Coding' (started by 'Uncle Bob') for when you bored and feel like googling.

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;

            }
            return result;      // returns newly created object 
        }
    }
}