// See https://aka.ms/new-console-template for more information
// using System.Collections.Generic;

namespace gradebook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dzienniczek Marysi");
            var grades = new List<double>() {12.3, 34.5, 56.7};
            grades.Add(11.4);

            var result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            } 
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}