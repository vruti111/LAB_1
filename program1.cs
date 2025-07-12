using System;
namespace LAB_1
{
	public class Program1
		static void Main(string[] args)
		{
			Console.Write("Enter number: ");
			string str = Console.ReadLine();
			int x = Convert.ToInt32(str);

			if (x % 2 == 0)
				Console.WriteLine("Number is even");
			else
				Console.WriteLine("Number is odd");

			Console.Read();
		}
	}
}





