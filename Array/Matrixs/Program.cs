using System;

namespace Matrixs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Matrix : two dimensinal array
            // values always assigned row by row
            //     0  1  2
            // 0 | 11 22 33 |
            // 1 | 44 55 66 |
            // first element 11 = [0][0]
            // third element 33 = [0][2]
            // index represented as [row][column]
            // read the matrix dimension

            Console.Write("Number of rows = ");
            int rows = int.Parse(Console.ReadLine());
			Console.Write("Number of columns = ");
			int cols = int.Parse(Console.ReadLine());
            //allocate the matrix
            int[,] matrix = new int[rows, cols];  // not new int[][]
            //enter the elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Matrix[{0},{1}] =", i, j );
                    int element = int.Parse(Console.ReadLine());
                    matrix[i, j] = element;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The matrix is a follow");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("The matrix is a follow");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
