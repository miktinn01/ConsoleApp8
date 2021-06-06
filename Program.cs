using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {


        static void Main(string[] args)
        {
            List<double> myList = new List<double>();   // a List is a dynamic version of an array

            var input = "";
            while (input != "x")
            {
                Console.WriteLine("enter the a number");
                input = Console.ReadLine();
                if (input != "x")
                {
                    myList.Add(double.Parse(input)); 
                }
            }          

            var sum = 0.0;             // declare variable to add sum of the array

            foreach (var number in myList)       // do this for every number in the array
            {
                sum += number;  // add to the previous total
            }

            Console.WriteLine($"\nThe sum of the numbers is {sum}");   // write to the screen

            Console.WriteLine(myList.Count);        // returns the value of elemets in a list
            var listAve = sum/ myList.Count;     // returns the average of elemets in a list
            Console.WriteLine($"\nThe average of the numbers is {listAve:N2}");   

            Console.ReadKey();

            //hello
            // change #2
            //c3

      

        }

        private static void DoAdd(string input)
        {
            throw new NotImplementedException();
        }
    }
}