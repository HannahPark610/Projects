using System;

namespace A2
{
    class MainClass
    {
        public static void Main()
        {
			Console.Write("Enter the amount of celsius what you choose: ");
			int celsius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kelvin = {0}", celsius + 273);
			Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}