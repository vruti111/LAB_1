using System;
namespace LAB_1
{
	public class armstrong
	{
		public static void Main(string[]args)
		{
            Console.Write("Enter a number: ");
            string input = Console.ReadLine(); // take input as string
            int num = int.Parse(input);        // convert to int
            int sum = 0;

            foreach (char ch in input)
            {
                int digit = ch - '0';
                sum += (int)Math.Pow(digit, input.Length);
            }

            Console.WriteLine(sum == num ? "Armstrong Number" : "Not an Armstrong Number");
        }
	}
}
