using System;

namespace IfElse
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first == second)
            {
                Console.WriteLine("both are equal");
            }
            else if (first > second)
            {
                Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("second number is ");
                }
                Console.WriteLine("both are not equal");
            }
            Console.Read();
        }
    }

