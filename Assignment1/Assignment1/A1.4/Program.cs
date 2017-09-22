using System;

namespace A2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char letterFirst, letterSecond, letterThird;

            Console.Write("Enter First letter: ");
            letterFirst = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Second letter: ");
			letterSecond = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Third letter: ");
			letterThird = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letterThird, letterSecond, letterFirst);
        }
    }
}
