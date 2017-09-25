using System;

namespace Assignment2
{
    class MainClass
    {
		public static int Fibonacci(int a1)
		{
			if (a1 <= 2)
				return 1;
			else
				return Fibonacci(a1 - 1) + Fibonacci(a1 - 2);
		}

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

            int a, b, c;
            int[,] arry1 = new int[50, 50];
            int[,] arry2 = new int[50, 50];
            int[,] arry3 = new int[50, 50];

			Console.Write("Input the size of the square matrix (less than 5): ");
			c = Convert.ToInt32(Console.ReadLine());

			/* Stored values into the array*/
			Console.Write("Input elements in the first matrix :\n");
			for (a = 0; a < c; a++)
			{
				for (b = 0; b < c; b++)
				{
					Console.Write("element - [{0},{1}] : ", a, b);
					arry1[a, b] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.Write("Input elements in the second matrix :\n");
			for (a = 0; a < c; a++)
			{
				for (b = 0; b < c; b++)
				{
					Console.Write("element - [{0},{1}] : ", a, b);
					arry2[a, b] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.Write("\nThe First matrix is :\n");
			for (a = 0; a < c; a++)
			{
				Console.Write("\n");
				for (b = 0; b < c; b++)
					Console.Write("{0}\t", arry1[a, b]);
			}
			Console.Write("\nThe Second matrix is :\n");
			for (a = 0; a < c; a++)
			{
				Console.Write("\n");
				for (b = 0; b < c; b++)
					Console.Write("{0}\t", arry2[a, b]);
			}
			/* calculate the sum of the matrix */
			for (a = 0; a < c; a++)
				for (b = 0; b < c; b++)
					arry3[a, b] = arry1[a, b] + arry2[a, b];
			Console.Write("\nThe Addition of two matrix is : \n");
			for (a = 0; a < c; a++)
			{
				Console.Write("\n");
				for (b = 0; b < c; b++)
					Console.Write("{0}\t", arry3[a, b]);
			}
			Console.Write("\n\n");




			// fibonacci sequence

			int num;

			Console.Write("Enter a number: ");
			num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fibonacci(num));
		}
	}
}