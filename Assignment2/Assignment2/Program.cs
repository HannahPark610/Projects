using System;

namespace Assignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int val = 5;
			int i, j, k;

			for (i = 1; i <= val; i++)
			{
				for (j = 1; j <= val - i; j++)
				{
					Console.Write("");
				}
				for (k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
            Console.WriteLine("Press enter go to next step");
            Console.ReadLine();


            // Square matrix


            // fibonacci sequence

            Console.WriteLine("Enter some to stop the fibonacci sequence.");
            int num = int.Parse(Console.ReadLine());

			int first = 1;
            Console.Write("{0},", first);
			int second = 1;
            Console.Write("{0},", first);
			int sum = 0;
            while (sum <= num)
            {
                sum = first + second;
                Console.Write("{0}, ", sum);

                first = second;
                second = sum;
            }
		}
	}
}