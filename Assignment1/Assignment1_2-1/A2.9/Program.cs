using System;

namespace A2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int option;

            Console.WriteLine("First Integer is 10"); 
            Console.WriteLine("Second Integer is 2");

            Console.Write("\nWhat do you want to do?\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.Write("\nEnter your choice :");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("{0} + {1} = {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("{0} - {1} = {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("{0} * {1} = {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    Console.Write("{0} / {1} = {2}\n", num1, num2, num1 / num2);
                    break;

                case 5:
                    break;

                default:
                    Console.Write("You choose worng option\n");
                    break;
            }
        }
    }
}
