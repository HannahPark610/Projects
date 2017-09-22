using System;

namespace A2
{
    class MainClass
    {
        public static void Main()
        {
            int Num1, Num2, result, result2, result3, result4;
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

			Console.ReadLine();
		}

	}
}