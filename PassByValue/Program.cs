using System;

namespace PassByValue
{
    // progaram for exchanging the values for two variable
    class MainClass
    {
        // Method declaration here
        // Method will always have a name, return datatype and arguments(
        // Method means seperate block for code

        public void swap(int x, int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside the swap Method a = {0}" + " b= {1}", x, y);
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Before nethod call values are" + "a = {0} & b = {1}", a, b);
            MainClass p = new MainClass();
            p.swap(a, b);
            Console.WriteLine("After nethod call values are" + "a = {0} & b = {1}", a, b);
            Console.Read();
        }
    }
}
