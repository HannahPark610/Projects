using System;

// Collection of game type elements
// Index always start = 0 / end = Length - 1
// Dynamic Array not possible, Give its size


namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // one dimensional array
            string[] cities = new string[10];
            cities[0] = "Vancouver";
            cities[1] = "Richmond";
            cities[2] = "Burnbay";

            // or
            string[] citiesName = { "Vancouver", "Richmond", "Burnbay" + "Kelowna", "New westminster"};

            Console.WriteLine("Unsorted : {0}", string.Join(" , ", citiesName));
            Array.Sort(citiesName);
            Console.WriteLine("sorted : {0}", string.Join(" , ", citiesName));
            Console.WriteLine("size of arry is {0}", citiesName.Length);

            Console.Read();
        }
    }
}
