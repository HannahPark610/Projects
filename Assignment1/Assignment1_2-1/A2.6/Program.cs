using System;

namespace A2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());

            if (number%2 == 0)
            {
                Console.Write("Number is an Even Number");
                Console.Read();
            }
            else
            {
				Console.Write("Number is an Odd Number");
				Console.Read();
            }
        }
    }
}
