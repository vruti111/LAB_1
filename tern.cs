using System;
namespace LAB_1
{

	public class term
	{
		public static void Main(string[] args)
		{
            Console.Write("Input the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num; 
                Console.Write(term);
                if (i < n) Console.Write(" + ");
                sum += term;
            }

            Console.WriteLine("\nThe Sum is: " + sum);
            Console.ReadLine();
        }
	}
}
