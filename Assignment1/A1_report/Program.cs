using System;

namespace A1_report
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			int Num1, Num2, result, result2, result3, result4;

			char letterFirst, letterSecond, letterThird;

            char somthing;

			int number;

			float Height;


			// A1-1
			Console.WriteLine("Hello");
			Console.WriteLine("Hannah");


            // A1-2
			Console.Write("Enter the First Number : ");
			Num1 = Convert.ToInt32(Console.ReadLine()); // 지정된 값을 32비트 부호있는 정수로 변환
			Console.Write("Enter the Second Number : ");
			Num2 = Convert.ToInt32(Console.ReadLine());

			result = Num1 + Num2;
			Console.WriteLine("{0}+{1}={2} ", Num1, Num2, result);

			result2 = Num1 - Num2;
			Console.WriteLine("{0}-{1}={2} ", Num1, Num2, result2);

			result3 = Num1 * Num2;
			Console.WriteLine("{0}*{1}={2} ", Num1, Num2, result3);

			result4 = Num1 / Num2;
			Console.WriteLine("{0}/{1}={2} ", Num1, Num2, result4);


            // A1-3
			Console.Write("Enter the amount of celsius what you choose: ");
			int celsius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kelvin = {0}", celsius + 273);
			Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

			// A1-4
            Console.Write("Enter First letter: ");
			letterFirst = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Second letter: ");
			letterSecond = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Third letter: ");
			letterThird = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("{0} {1} {2}", letterThird, letterSecond, letterFirst);

			// A1-5
			Console.Write("Enter somthing : ");
			somthing = Convert.ToChar(Console.ReadLine());

			if ((somthing == 'a') || (somthing == 'e') || (somthing == 'i') || (somthing == 'o') || (somthing == 'u'))
				Console.WriteLine("This is a lowercase vowel.");
			else if ((somthing >= '0') && (somthing <= '9'))
				Console.WriteLine("It's a digit.");
			else
				Console.Write("It's another thing");

			// A1-6
			Console.Write("Enter the number : ");
			number = int.Parse(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.Write("Number is an Even Number");
				Console.Read();
			}
			else
			{
				Console.Write("Number is an Odd Number");
				Console.Read();
			}


			// A1-7
			Console.Write("Enter the height of the person : ");
			Height = Convert.ToInt32(Console.ReadLine());

			if (Height < 150.0)
				Console.Write("Dwarf \n\n");
			else if ((Height >= 150.0) && (Height <= 165.0))
				Console.Write("Average height \n\n");
			else if ((Height >= 165.0) && (Height <= 195.0))
				Console.Write("Taller \n\n");
			else
				Console.Write("Too much height \n\n");

			// A1-9
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

            
            Console.Read();

			// A1-10
			DateTime date = new DateTime(2017, 9, 12);
			Console.WriteLine(date.ToString("yyyy-MM-dd"));
			Console.WriteLine(date.ToString("dd-MMM-yy"));
			Console.WriteLine(date.ToString("M/d/yyyy"));
			Console.WriteLine(date.ToString("M/d/yy"));
			Console.WriteLine(date.ToString("MM/dd/yyyy"));
			Console.WriteLine(date.ToString("MM/dd/yy"));
			Console.WriteLine(date.ToString("yy/MM/dd"));
			Console.Read();

//			return 0;
        }
    }
}
