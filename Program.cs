using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // get a number
            Console.WriteLine("enter the a number");
            var input1 = Console.ReadLine();
            var number1 = double.Parse(input1);     // convert string to double

            // get a number
            Console.WriteLine("enter the anumber");
            var input2 = Console.ReadLine();
            var number2 = double.Parse(input2);     // convert string to double

            // get a number
            Console.WriteLine("enter the a number");
            var input3 = Console.ReadLine();
            var number3 = double.Parse(input3);     // convert string to double

            // get a number
            Console.WriteLine("enter the a number");
            var input4 = Console.ReadLine();
            var number4 = double.Parse(input4);     // convert string to double

            List<double> myList = new List<double>();   // a List is a dynamic version of an array
            myList.Add(number1);
            myList.Add(number2);
            myList.Add(number3);
            myList.Add(number4);

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
    }
}