using System;
using System.Collections.Generic;

namespace Comparators
{
    class MainClass
    {
        // 1. create a NumberComparator class that implement
        private class StudentComparator : IComparer<string>
        {
          
            public int Compare(string x, string y)
            {
				var lastName1 = x.Substring(x.IndexOf(' ') + 1);
				var lastName2 = y.Substring(y.IndexOf(' ') + 1);
				return lastName1.CompareTo(lastName2);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 10, 11, 12 };
            Console.WriteLine("Numbers Sorted by module 6");
            // using lamdba expression
            Array.Sort(numbers, (x, y) => (x % 6).CompareTo(y % 6));

            //excerise : use the IComparer interface for sorting here

            Console.WriteLine("output");
            foreach(int no in numbers)
            {
                Console.Write("{0}\t", no);
            }

            // Sorting by last name

            string[] students = { "Hannah", "Shinji", "Saeko", "Ai", "Sena" };
            Console.WriteLine("students sorted by first letter or their");
            Array.Sort(students, new StudentComparator());
            foreach(string students)
        }
    }
}
