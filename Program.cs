using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    // test change 15:09 7 jun
    class Program
    {
        static void Main(string[] args)     //
        {
            var Book1 = new Book("Scotts grade book");      //piece of state "Scotts grade book" is encapsulated inside the book object
            Book1.AddGrade(89.1);       
            Book1.AddGrade(90.5);
            Book1.AddGrade(77.5);
            Book1.CalcStats();
        }
        private static void DoAdd(string input)
        {
            throw new NotImplementedException();
        }
    }
}