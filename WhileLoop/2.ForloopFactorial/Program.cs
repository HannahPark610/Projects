using System;

namespace ForloopFactorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Factorial 2! = 2 * 1 = 2
            //Factorial 3! = 3 * 2 * 1 = 6
            //Factorial 4! = 4 * 3 * 2 * 1 = 24


            //Intialization; condirion; increment/secrement;

            int n = 5;  // if int n = 20 --> overfloat (answer: -2147483648 --> should be before 2147483648)
			int factorial = 1;
            for (int i = n; i >= 1; i-- )
            {
                factorial = factorial * i;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);

			int m = 20;  // overfloat (answer: -2147483648 --> should be under 2147483648)
			decimal factorial1 = 1;  // ( change int ---> decimal )
			for (int i = m; i >= 1; i--)
			{
				factorial1 = factorial1 * i;
			}
			Console.WriteLine("{0}! = {1}", m, factorial1);

            // variation of for loop
            // For - each loop
            Console.WriteLine("For each example");
            string[] dayName = new string[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            // datatype variable keyword(in) collection_name
            // foreach is used over collections i.g list, arrays
            // maps, sets
            foreach(string day in dayName)
            {
                Console.WriteLine(day);
            }

            Console.Read();
		}
    }
}
