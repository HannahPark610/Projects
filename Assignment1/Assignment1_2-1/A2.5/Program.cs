using System;

namespace A2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char somthing;

            Console.Write("Enter somthing : ");
            somthing = Convert.ToChar(Console.ReadLine());

            if ((somthing == 'a') || (somthing == 'e') || (somthing == 'i') || (somthing == 'o') || (somthing == 'u'))
                Console.WriteLine("This is a lowercase vowel.");
            else if ((somthing >= '0') && (somthing <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another thing");
        }
    }
}
