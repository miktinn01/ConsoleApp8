using System.Collections.Generic;

namespace ConsoleApp8
{
    class Book
    {
        public Book(string name)       //
        {
            grades = new List<double>();
            this.name = name;       // this
        }
        public void AddGrade(double grade)      //public is an access modifier, it controls access to the member of the class. 
        {
                grades.Add(grade);
        }
        private List<double> grades;
        private string name;    // creates a private field name
    }
}