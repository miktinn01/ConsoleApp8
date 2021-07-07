using System;
using System.Collections.Generic;

namespace GradeBook_v3
{
    class Program
    {
        static void Main(string[] args) 
        {
            var Book1 = new Book("Scotts grade book");      //piece of state "Scotts grade book" is encapsulated inside the book object

            //loop to collect grades from concole until user enters letter q
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try   // 1st try to do the code below... if it fails it will jumpt to the catch statement
                {
                    var grade = Convert.ToDouble(input);
                    //var grade = Double.Parse(input);  // this line does the same as the above 

                    Book1.AddGrade(grade);
                }
                catch(ArgumentException ex)
                // catch(Exception ex) this exception will catch everything which isn't always the right thing
                // we want to be specific about which errors to catch and how to handle them
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // allows you to do something regardless of chaos thats happening above
                }
            }

            var StatisticsClass = Book1.GetStats();
            //Console.WriteLine($"\nStatistics for {Book.Name}");
            Console.WriteLine($"\nThe lowest grade is {StatisticsClass.Low}");
            Console.WriteLine($"\nThe highest grade is {StatisticsClass.High}");
            Console.WriteLine($"\nThe average grade is {StatisticsClass.Average:N2}");
            Console.WriteLine($"\nThe letter grade is {StatisticsClass.Letter}");
        }
        private static void DoAdd(string input)
        {
            throw new NotImplementedException();
        }
    }
}