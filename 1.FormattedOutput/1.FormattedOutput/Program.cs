using System;

namespace FormattedOutput
{
    class MainClass
    {
         static void Main(string[] args)
        {
            double someVar = 1.234;  //01.234000
            Console.WriteLine("{0:00.000000}", someVar);
            float pi = 3.14519206f; // 3.15 : F4 F means Fixed up to 4 digit
            Console.WriteLine("{0:F3}", pi); //F다음 숫자는 3개가 나옴 How many digit you want?
            //Hexadecimal : X
            Console.WriteLine("{0:X}", 250);
            //string formationg with left align or right align
            double colaPrice = 1.2034;
            string cola = "Coca cola";
            double fantaPrice = 1.203;
            string fanta = "Fanta dizzy";
			double pepsiPrice = 1.502;
			string pepsi = "Pepsi";

            Console.WriteLine("------------------");
            //-sign means left align + means right aligned
            //number like 15 means total space is 15
            Console.WriteLine("{0,-15} | {1,15:F2}", cola, colaPrice);
            Console.WriteLine("{0,-15} | {1,10:F2}", fanta, fantaPrice);
            Console.Read();
        }
    }
}
