using System;

namespace OptionalParameters
{
    class MainClass
    {
        // Optional parameters
        // if you dont pass the parameters in funtion call
        // it thates the optinal parameters value

        public void PrintNumber(int start = 0, int end = 20)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MainClass p = new MainClass();
            p.PrintNumber();
            p.PrintNumber(5, 10);
            p.PrintNumber(15);
            p.PrintNumber(end: 40, start: 35);

            Console.Read();
        }
    }
}
