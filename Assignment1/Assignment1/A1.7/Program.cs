using System;

namespace A2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			float Height;

			Console.Write("Enter the height of the person : ");
			Height = Convert.ToInt32(Console.ReadLine());

			if (Height < 150.0)
				Console.Write("Dwarf \n\n");
			else if ((Height >= 150.0) && (Height <= 165.0))
				Console.Write("Average height \n\n");
			else if ((Height >= 165.0) && (Height <= 195.0))
				Console.Write("Taller \n\n");
			else
				Console.Write("Too much height \n\n");
        }
    }
}
