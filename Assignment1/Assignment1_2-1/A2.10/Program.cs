using System;

namespace A2
{
    class MainClass
    {
        static int Main(string[] args)
        {
            DateTime date = new DateTime(2017, 9, 12);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
			Console.WriteLine(date.ToString("dd-MMM-yy"));
			Console.WriteLine(date.ToString("M/d/yyyy"));
			Console.WriteLine(date.ToString("M/d/yy"));
			Console.WriteLine(date.ToString("MM/dd/yyyy"));
			Console.WriteLine(date.ToString("MM/dd/yy"));
			Console.WriteLine(date.ToString("yy/MM/dd"));
			Console.Read();

			return 0;
        }
    }
}
