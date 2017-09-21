using System;

namespace WhileLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Entry controlled loop
			// 1.Intialization
			// 2.Condition
			// 3.Increment / Decrement
			
            int i = 1; // 1.Intialization
            Console.WriteLine("Series from 1 to 50");
            while(i<=50) // 2.Condition
            {
                Console.Write("\t{0}", i);
                i++;  // 3.Increment
            }

            //exit Controlled loop Do...While();

            int j = 1;
            Console.WriteLine("Series from 1 to 50");
            do
            {
                Console.Write("\t{0}", j);
                j++;
            } while (j <= 50);

            Console.Read();
        }
    }
}
